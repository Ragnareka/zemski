using ExcelDataReader;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApplication1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
       

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Rectangle_Click(object sender, RoutedEventArgs e)
        {

        }

       // private BindingList <Model> ToDoData;
        
       
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            // Создаем поток для чтения.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            { 
                var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read);
                BindingList<Model> lstModel ;
                if (openFileDialog.FileName.Contains(".xlsx"))
                // В зависимости от расширения файла Excel, создаем тот или иной читатель.
                // https://github.com/ExcelDataReader/ExcelDataReader#readme
                // Читатель для файлов с расширением *.xlsx.
                { var excelReader = ExcelReaderFactory.CreateOpenXmlReader(stream);
                    // Читаем, получаем DataSet и работаем с ним как обычно.
                    // var result = excelReader.AsDataSet();
                    DataTable result = excelReader.AsDataSet().Tables[0];

                     lstModel = Model.GetDataTableRow(result);

                        // После завершения чтения освобождаем ресурсы.

                        excelReader.Close();
                }
                else {

                    // Читатель для файлов с расширением *.xls.
                    var excelReader = ExcelReaderFactory.CreateBinaryReader(stream);
                    // Читаем, получаем DataSet и работаем с ним как обычно.
                    DataTable result = excelReader.AsDataSet().Tables[0];

                    lstModel = Model.GetDataTableRow(result);
                    // После завершения чтения освобождаем ресурсы.
                    excelReader.Close();
                   
                }
                // у нас есть лист с первой страницей, теберь ее нужно вывести на экран в первфый таб - Рента

                dgRENTA.ItemsSource = lstModel;



            }
        
        
        }

        private void Open_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
