   M S B A M L   `   `   `  ����  WpfApplication1     WpfApplication1.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     6F     � Title$  ProgramName��5   	   $	��350��6   $	��525��6*    � 	Resources 5         StoryboardMENU �� TargetProperty �� 
TargetName9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value R� KeyTime  System.Windows.Visibility   Hidden R� Value	   Visible  StoryboardClose��%�  &	        &	 $    �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $
 grid��6�   .\�5	        $ 0��6'   $ 0Q�63     5
      $ 0:0:0.3��6'   $ 74.75Q�69   5      U� 5      $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.Y)�6,   $
 grid��6�   .\�5        $ 0��6'   $ 0Q�63     5      $ 0:0:0.3��6'   $ -1.335Q�69   5      T� 5      $ (UIElement.Visibility)�6,   $ 
rectangle2��6_   ..�5      i� $ 0��6)   # Z 65   i� 5      $ 0:0:0.3��6)   # Z	 6;   5      T� 5      $ (UIElement.Visibility)�6,   $ 	rectangle��6_   ..�5      i� $ 0��6)   # Z	 65   i� 5      $ 0:0:0.3��6)   # Z 6;   5      5      �� 5   
   .��5      U� $U O(UIElement.RenderTransform).(TransformGroup.Children)[3].(TranslateTransform.X)�6,   $
 grid��6�   .\�5        $ 0��6'   $ 73.436Q�63     5      $ 0:0:0.3��6'   $ -5.007Q�69   5      T� 5      $ (UIElement.Visibility)�6,   $ 	rectangle��6_   ..�5      i� $ 0��6)   # Z 65   i� 5       $ 0:0:0.3��6)   # Z	 6;   5!      T� 5"      $ (UIElement.Visibility)�6,   $ 
rectangle2��6_   ..�5#      i� $ 0��6)   # Z	 65   i� 5$      $ 0:0:0.3��6)   # Z 6;   5%      5&      5'      
 � Triggers
 5(      :� 5)   
    :� RoutedEvent$ ButtonBase.Click��6    :� 
SourceName$ 	rectangle��66   .[�5*      �� #��[  6   5+      :� 5,   
   $ ButtonBase.Click��6   $ 
rectangle2��66   .[�5-      �� #��[ 6   5.      .��51      � .+�53   
   �� $��25,2,0.4,-2.2q�6   .+�56      �� -   5         ��Name$ tabControl1��56      .@�57      �� -   5         ��Name$ tabItem1��57   ,   $��tabItem1��6   .��59      � .+�5:      &   System.Windows.Controls.DataGrid  -   5          Name$ dgRENTA��5:   #   $
��Bold"�66      Columns 5;      0  *System.Windows.Controls.DataGridTextColumn  5<   "   ,  &System.Windows.Controls.DataGridColumn   Header$% Показатель\Район��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 65   ��  �� Path$
 name�6V     5=   "   $' !Площадь посеянная��6Z    65   �� $ Sposev�6Z     5>   "   $% Площадь убранная��6W    65   �� $
 Subr�6W     5?   "   $ Затраты всего��6[    65   �� $ ALLmoney�6[     5@   "   $1 +Затраты на оплату труда��6[    65   �� $ moneyTR�6[     5A   "   $&  Затраты на семена��6^    65   �� $ moneySemena�6^     5B   "   $5 /Затраты на элитные семена��6c    65   �� $ moneySemenaElit�6c     5C   "   $/ )Минеральные удобрения��6`    65   �� $ moneyUdobMin�6`     5D   "   $1 +Органические удобрения��6_    65   �� $ moneyUdobOrg�6_     5E   "   $7 1Затраты на средства защиты��6\    65   �� $ 	moneySave�6\     5F   "   $6 0Затраты на электроэнергию��6b    65   �� $ moneyElecticity�6b     5G   "   $4 .Затраты на нефтепродукты��6[    65   �� $ moneyOIL�6[     5H   "   $0 *Затраты на страхование��6a    65   �� $ moneyStrahovka�6a     5I   "   $: 4Содержание основных средств��6]    65   �� $ 
moneyOsnov�6]     5J   "   $. (Выход продукции всего��6Z    65   �� $ Product�6Z     5L   "   $+ %Себестоимость всего��6Y    65   �� $ Price�6Y     5M   "   $ Реализовано��6Z    65   �� $ Realize�6Z     5N   "   $N HСебестоимость реализованной продукции��6a    65   �� $ AllVolumePrice�6a     5O   "   $ Выручено��6]    65   �� $ 
VolumeProd�6]   5S      5T      5U      �� 5V      -   5        $ tabItem2��5V   ,   $��tabItem2��6   .��5W      � .+�5X        -   5        $ dgRENTA2��5X   #   $
��Bold"�67   5Y      5Z      5[      � 5]      .+�5^      � $��5q�6    � ColumnDefinitions 5_      �� 5`      �� 5a      .+�5c      �� $��Коэффициент��6   �� 5d      -   5         ��Name$ Коэффициент��5d      $��1��63   $��0,002��6C   5f      �� 5g      -   5         ��Name$ 	Calculate��5g      $��Пересчитать��6,   5h      5j      � 5k   
   -   5         �Name$
 grid��5k      $
��Left=�6   $	��100��68   
�������$��	-75 0 0 0q�6Z    J� RenderTransformOrigin$ 0.5,0.5&�6m   z�5l      V� 5m      .~�5n      �� �� 5o      �� 5p      T� 5q      5r      .+�5u      � .+�5w      �� -	   5        $
��MENU��5w      $��0��6)   $��75��69   $
��Left=�6D   .+�5y      �� -
   5        $	��New��5y      $��40��6=   $��Right=�6I   $��	0,0,0.2,0q�6e   $��75��6x   .��5z      �� $��Новый проект��6$   $
��Wrap=�5{       �� TextAlignment$ Center=�5|      5}      �� 5~      -   5        $
��Open��5~      $��40��6*   $��	0,0,0.2,0q�66   $��Right=�6I   $��75��6e   .��5      �� $!��Открыть проект��6$   $
��Wrap=�5�      $ Center=�5�      5�      �� 5�      -   5        $
��Save��5�      $��40��6+   .��5�      �� $%��Сохранить проект��6$   $
��Wrap=�5�      $ Center=�5�      5�      �� 5�      -   5        $	��Exp��5�      $��40��6*   .��5�      �� $��Экспорт��6$   $
��Wrap=�5�      $ Center=�5�      5�      5�      �� 5�      -   5        $��OpenCloseMenu��5�      $��1��62   $��20��6B   $��Right=�6N   .+�5�      �� -   5        $ 
rectangle2��5�      $y�Hidden=�62   $��18(�6]   $��֍��6k   ��6F   Z� 6�   �� 5�      -   5        $ 	rectangle��5�      $��18(�6H   $��֍��6V   ��62   Z� 6c   5�      5�      5�      5�      5�      