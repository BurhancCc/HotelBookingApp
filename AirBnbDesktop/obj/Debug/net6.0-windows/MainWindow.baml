   M S B A M L   `   `   `  ����H  DAirBnbDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirBnbDesktopAirBnbDesktop  5   	       AirBnbDesktop.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirBnbDesktop     5   	   -   5        $��LoginWindow��5   A     � Title$  
MainWindow��6	    � WindowStartupLocation$ CenterScreen=�6   $	��320��6T   $	��490��6a    � 
ResizeMode$ NoResize=�6m   
���   �.��5
      ��  �� Orientation$ Vertical=�6   ���#a6d9ef$��2q�6=   $��Stretch=�6H   $��Stretch=�6d   .+�5   
   ��  �� CornerRadius$ 25��6   $��20,10,20,10q�6#   
���  ��
�������$	��330��6]   ._�5      �� $ Vertical=�6   .+�5      �� $��Welcome��6   $��25(�6*   $��Center=�68   $
��Bold"�6U   $��2,5,2,0q�6g   $��Bottom=�6x   �� 5      $��Please Login to Proceed��6   $��20(�6:   $��Center=�6H   $��Medium"�6l   $��2,0,2,10q�6�   $��Italic$�6�   $	��Top=�6�   � 5      $��2q�6    � ColumnDefinitions 5      �� 5      $	��110 �6+   �� 5      $	��200 �6+    � RowDefinitions 5      �� 5      �� 5      �� 5      .+�5      �� $��0��6   $��0��6)   $	��0,5q�69   $��
User Id : ��6F   $��Center=�6[   $��Right=�5      �� 5      -   5         ��Name$ 	txtUserId��5   ;   $��0��6   $��1��6+   $	��0,5q�6N   $	��150��6[   $��Center=�6g   $
��Left=�5      ��5   �   �� *
Username+ �� Mode$ TwoWay=�	 �� UpdateSourceTrigger$	 PropertyChanged=�5      �� 5      $��1��6   $��0��6)   $	��0,5q�69   $��Password : ��6F   $��Center=�6\   $��Right=�6~   G� 5       -   5        
 G�Name$
 txtPassword��5    m   $��1��6P   $��1��6]   $	��0,5q�6�   $	��150��6�   $��Center=�6�   $
��Left=�6�   �� 5"      $ 
Horizontal=�6!   $��1��6:   $��2��6J   $��2��6W   $��Center=�6k   .+�5#      �� -   5         ��Name$ btnLogin��5#   �   $��LOGIN��6!   $
��2,10q�6�   $	��100��6�   $��30��6�   ���#80ff00
���   �
���������61   �� *LoginCommand+$ TwoWay=�$	 PropertyChanged=�6�   5$      5&      �� 5'      $��30��6   $	��210��6$   .��5(      �� 
���   � �� CommandParameter 63   ��  �� ElementName$ LoginWindow�� �� Command 6h   �� *OpenRegisterClick+$ TwoWay=�$	 PropertyChanged=�.�6�   &$Not a Member? Click here to Register6�   5)      5*      5+      5,      5-      