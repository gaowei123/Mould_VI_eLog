   M S B A M L   `   `   `  ����  VI_eLog    VI_eLog.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   -   5        $	��764��5   	   $
��1024��6     � WindowStartupLocation$  CenterScreen=�6#    � WindowState$ 	Maximized=�6H    � Icon$ icon.ico��6`    � WindowStyle$ ThreeDBorderWindow=�6p    � Title$' !Mould Visual Inspection eLogsheet��6�    � 	Resources 5       
  Color1��%'   &	        ��5   
   	Black��6&   5      .��5      (�  (� Stretch$
 Fill=�6   .��5	   
   � $	��724��6   $
��1000��6   ��5
      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 White��6#   
 � Offset$
 1Q�61   � 5      $	 	#FF99B4D1��6#   $
 1Q�65   5      .+�5      � $��50��6   $	��Top=�6   $
��Left=�67   $
��1000��6R   ��5      �� 5      $ 0.5,1&�6*    � MappingMode$ RelativeToBoundingBox=�6;   $ 0.5,0&�6_    �� RelativeTransform 5      V� 5      .~�5   "   ��  �� CenterY$	 0.5Q�61    �� CenterX$	 0.5Q�6?   �� 5   "    �� CenterY$	 0.5Q�60    �� CenterX$	 0.5Q�6>   �� 5   "    �� Angle$ 90Q�62    �� CenterY$	 0.5Q�6=    �� CenterX$	 0.5Q�6K   T� 5   "   5      .��5      � $	 	#FF012E53��6'   $
 1Q�69   � 5      $	 White��6'   � 5      $	 White��6'   $
 0.067Q�65   5      .+�5       �� -   5         ��Name$ 
SystemLogo��5       $��49��6,   $
��Left=�68   $)��#Resources/Mainpage/logo-ir4-tts.png��6S   $
��Fill=�6�   $��Center=�6�   $	��286��6�   $��10,0,0,1q�6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   z�5!      V� 5"      .~�5#      �� �� 5$       �� AngleX$ 0.434Q�6,   �� 5%      T� 5&       T� X$ 0.238Q�61   5'      5)      �� 5*      -   5         ��Name$ label_Group��5*      $��Group��6-   $��Arial)�6=   $��10(�6P   $
��Bold"�6^   ���#b0c4de$��24��6�   $��Center=�6�   $��Center=�6�   $��Center=�6�   $	��122��6�   $��700,40,365,13q�6�   $y�Hidden=�6  5+      � 5[      -   5         �Name$ MainGrid��5[      $	��672��6%   $��Right=�62   $��Bottom=�6N   $
��1000��6i   ��5\      �� 5]       �� ImageSource$' !Resources/Mainpage/Background.jpg��6!    j� TileMode$
 Tile=�6Q    j� Stretch$
 None=�6a    � ColumnDefinitions 5_      �� 5`      �� 5a      $��0* �6'   5c      �� 5d      -   5        $ CompanyLogo��5d      $��39��6)   $
��Left=�65   $��1312,0,0,680q�6P   $&�� Resources/Mainpage/UBCT logo.png��6f   $��Uniform=�6�   $��Bottom=�6�   $��44��6�    � ToolTip$ 	Minimize ��6�   $ 0.563,-0.179&�6�   �� 5e      -   5        $ label_SystemVersion��5e      $��Version��61   $��Afial)�6C   $��10(�6V   $��Normal"�6d   ���#000000$��Right=�6�   $��Right=�6�   $��	0,10,10,0q�6�   $��Center=�6�   $	��117��6  $��22��6  $	��Top=�6  5f      5h      ��5i      �� 5j   
   $' !Resources/Mainpage/Background.jpg��6   $ UniformToFill=�6E   5l      