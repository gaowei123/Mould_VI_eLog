   M S B A M L   `   `   `  ����D  @VI_eLog, Version=1.0.1.810, Culture=neutral, PublicKeyToken=null?$clr-namespace:VI_eLog.UserControllerVI_eLog.UserController  5      -    'VI_eLog.UserController.McStopMessageBox   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:VI_eLog.UserController     5      $	��260��5       $	��350��6-   .��5      � $	��260��6   $	��350��6     J� Effect  5   
   3  -System.Windows.Media.Effects.DropShadowEffect  5         Color$ Black��6      
BlurRadius$ 20Q�6-      ShadowDepth$ 0Q�6=      Opacity$ 1Q�6M   6[   .+�5   
   � -   5        $��gdMessageBlock��5      $	��350��6%   $��80��61   $��	0,2,0,178q�6=   
�������.+�5      �� -   5        $��txtMcStatus��5      $y�	Collapsed=�6+   6D   �� 5      -   5        $��txtMessageBlock��5      $	��300��6/   $��60��6;   $��	10,8,10,4q�6G   $��16(�6Z   $��Center=�6h   $
��Wrap=�6�    �� TextAlignment$
 Left=�6�   
�������6�   5      � 5   
   -   5        $��gdInputReasonBlock��5      $	��350��6)   $	��120��65   $��	0,82,0,58q�6B   
�������.+�5      �� $	��350��6   $	��120��6%    �� Orientation$ Vertical=�62   .+�5      �� -   5         ��Name$ 	cbbReason��5       �� DisplayMemberPath$
 Name��6.   	 �� SelectedValuePath$	 ID��6G   $��16(�6^   $	��300��6l   $��40��6x   $
��10,0q�6�   �� 5      -   5        
 ��Name$
 	txtReason��5      $	��300��6-   $��16(�69   $��60��6G   $��0,10,0,0q�6S   5      5      � 5   
   -   5        $��gdButtonBlock��5      $	��350��6$   $��60��60   $��0,177,0,-27q�6<   
�������.+�5       �� $	��300��6   $��50��6%   $ 
Horizontal=�61   .+�5!      �� -   5        $��	btnSubmit��5!       
  Submit#���   6C   $��18(�6f   $
��Bold"�6t   
��� � �$	��100��6�   $��40��6�   $��25,0,0,0q�6�   6�   �� 5"      -	   5        $��btnCanel��5"       
 cancel#���  6@   $��18(�6c   $
��Bold"�6q   
���  ��$	��100��6�   $��40��6�   $��50,0,0,0q�6�   6�   5#      5$      5&      5*      