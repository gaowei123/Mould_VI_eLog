   M S B A M L   `   `   `  ����D  @VI_eLog, Version=1.0.1.810, Culture=neutral, PublicKeyToken=null?$clr-namespace:VI_eLog.UserControllerVI_eLog.UserController  5      -    'VI_eLog.UserController.DefectController   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35U QWPFToolkit, Version=3.5.40128.1, Culture=neutral, PublicKeyToken=31bf3856ad364e35H 9http://schemas.microsoft.com/winfx/2006/xaml/presentation      5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      6local$clr-namespace:VI_eLog.UserController     5      $	��100��5   3   .��5      (�   (� Stretch$
  Fill=�6   .��5	   
   �  � ColumnDefinitions 5
      �� 5      $
��137* �6#   �� 5      $	��13* �6#   .+�5      �� $��55��6   $��0,0,0,0q�6%   $	��Top=�66    �� Orientation$ 
Horizontal=�6N   $��2��6g   .+�5      �� -   5         ��Name$ btnDefectCode��5      $	��XXX��60   $��0,0,0,0q�6>   $	��210��6O   6[   �� 5      $
��Left=�6   $��0,0,0,0q�68   $��90��6I   $ Vertical=�6T   .+�5      �� -   5         ��Name$ txtDefectQty��5      $��0,0,0,0q�64    �� TextWrapping$
 Wrap=�6E   $��0��6Y   $��Right=�6b   $��90��6~   $��Center=�6�   $��Center=�6�   $��35��6�   �� 5      $��0,0,0,0q�6!   $ 
Horizontal=�62   $��20��6K   .+�5      �� -   5        $ btnUp��5   !   $�� ��60   $��0,0,0,0q�6;    J� RenderTransformOrigin$ 1.158,0.431&�6L   $��30��6p   ��5      �� 5   "    �� ImageSource$+ %/VI_eLog;component/Resources/back.png��6-    �� RelativeTransform 5   &   V� 5   *   .~�5   .   �� 	 �� CenterY$		 0.5Q�6=   
 �� CenterX$	
 0.5Q�6K   �� 5   .    �� CenterY$	 0.5Q�6<    �� CenterX$	 0.5Q�6J   �� 5   .    �� CenterY$	 0.5Q�6>    �� CenterX$	 0.5Q�6L   T� 5    .   5!   +   5#   #   5%      �� 5&      -   5        $ btnDown��5&   !   $�� ��62   $��20��6=   $��0,0,0,0q�6I   $��30��6\   ��5'      �� 5(   "   $. (/VI_eLog;component/Resources/forward.png��6-    5)   &   V� 5*   *   .~�5+   .   �� $		 0.5Q�6=   $	
 0.5Q�6K   �� 5,   .   $	 0.5Q�6<   $	 0.5Q�6J   �� 5-   .   $	 0.5Q�6>   $	 0.5Q�6L   T� 5.   .   5/   +   51   #   53      �� 54      -   5        $ btnSave��54   !   $�� ��62   $��Right=�6=   $��30��6Y   $��0,0,0,0q�6d   ��55      �� 56   "   $+ %/VI_eLog;component/Resources/save.png��6-    j� Stretch$ Uniform=�6a   58      5:      5<      5>      �� 5?      $ 
Horizontal=�6   $��0,55,0,0q�62   $��2��6D   .+�5@      �� $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5A      �� -   5        $��lbl08��5A      $��08��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5B      �� 5C       �� EndPoint$ 0.5,1&�62    �� 
StartPoint$ 0.5,0&�6C   .��5D   "   �  � Color$ Black��6/    � Offset$ 0Q�6=   � 5E   "   $ 	#FF080707��6/   $ 1Q�6A   5F      5H      �� 5I      -   5        $��txtQty08��5I      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5J      5K      �� 5L      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5M      �� -   5        $��lbl09��5M      $��09��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5N      �� 5O      $ 0.5,1&�62   $ 0.5,0&�6C   .��5P   "   � $ Black��6/   $ 0Q�6=   � 5Q   "   $ 	#FF080707��6/   $ 1Q�6A   5R      5T      �� 5U      -	   5        $��txtQty09��5U      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5V      5W      �� 5X      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5Y      �� -
   5        $��lbl10��5Y      $��10��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5Z      �� 5[      $ 0.5,1&�62   $ 0.5,0&�6C   .��5\   "   � $ Black��6/   $ 0Q�6=   � 5]   "   $ 	#FF080707��6/   $ 1Q�6A   5^      5`      �� 5a      -   5        $��txtQty10��5a      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5b      5c      �� 5d      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5e      �� -   5        $��lbl11��5e      $��11��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5f      �� 5g      $ 0.5,1&�62   $ 0.5,0&�6C   .��5h   "   � $ Black��6/   $ 0Q�6=   � 5i   "   $ 	#FF080707��6/   $ 1Q�6A   5j      5l      �� 5m      -   5        $��txtQty11��5m      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5n      5o      �� 5p      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5q      �� -   5        $��lbl12��5q      $��12��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5r      �� 5s      $ 0.5,1&�62   $ 0.5,0&�6C   .��5t   "   � $ Black��6/   $ 0Q�6=   � 5u   "   $ 	#FF080707��6/   $ 1Q�6A   5v      5x      �� 5y      -   5        $��txtQty12��5y      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5z      5{      �� 5|      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5}      �� -   5        $��lbl01��5}      $��01��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5~      �� 5      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty01��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl02��5�      $��02��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty02��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl03��5�      $��03��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty03��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl04��5�      $��04��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty04��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl05��5�      $��05��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty05��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl06��5�      $��06��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty06��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      �� 5�      $ Vertical=�6   $��0,0,0,0q�64   $��25��6E   .+�5�      �� -   5        $��lbl07��5�      $��07��6)   $��8(�66   $��20��6D   $��Center=�6P   }�. $��1q�6�   $
��Bold"�6�   ��5�      �� 5�      $ 0.5,1&�62   $ 0.5,0&�6C   .��5�   "   � $ Black��6/   $ 0Q�6=   � 5�   "   $ 	#FF080707��6/   $ 1Q�6A   5�      5�      �� 5�      -   5        $��txtQty07��5�      $��0��6.   $��Center=�67   $��Center=�6Y   $��10(�6}   ���	#FF080707$��25��6�   $
��Bold"�6�   .��6�   5�      5�      5�      5�      5�      5�      