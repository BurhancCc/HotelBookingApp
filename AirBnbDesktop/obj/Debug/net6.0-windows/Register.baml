   M S B A M L   `   `   `  ����H  DAirBnbDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirBnbDesktopAirBnbDesktop  5   	       AirBnbDesktop.Register   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirBnbDesktop     5   	     � Title$  Register��5   	    � 
ResizeMode$ NoResize=�6   $	��350��60   $	��800��6=    � WindowStartupLocation$ CenterScreen=�6I   .��5	      � ��5
   
   �� 5       �� ImageSource$ /Resources/Bg.png��6   .+�5   
   �� 
���   �$��
Full Name:��6#   $��16(�68   $
��Left=�6F   $��	15,34,0,0q�6a   $	��Top=�6t   �� 5   
   -   5        $��
tbIdNumber��5      $��16(�6n   $
��Left=�6|   $��23��6�   $��
142,38,0,0q�6�    �� TextWrapping$
 Wrap=�6�   $	��Top=�6�   $	��614��6�   ��6$   �� *
FullName+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   
���   �$��	Username:��6$   $��16(�68   $
��Left=�6F   $��	15,82,0,0q�6a   $	��Top=�6t   �� 5   
   
���   �$��	Password:��6#   $��16(�67   $
��Left=�6E   $��
408,84,0,0q�6`   $	��Top=�6t   �� 5   
   -   5        $��
tbUsername��5      $��16(�6n   $
��Left=�6|   $��23��6�   $��
142,88,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   ��6$   �� *
Username+$ TwoWay=�$ PropertyChanged=�6�   G� 5   
   -   5        $��
tbPassword��5      $��16(�6V   $
��Left=�6d   $��
530,90,0,0q�6   $	��Top=�6�   $	��227��6�   �� 5   
   
���   �$��Email:��6#   $��16(�64   $
��Left=�6B   $��408,128,0,0q�6]   $	��Top=�6r   �� 5   
   $��16(�6Y   $
��Left=�6g   $��23��6�   $��530,134,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��227��6�   ��6   �� *Email+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   
���   �$��Contact:��6#   $��16(�66   $
��Left=�6D   $��
15,128,0,0q�6_   $	��Top=�6s   �� 5   
   -   5         ��Name$ tbPhone��5      $��16(�6l   $
��Left=�6z   $��23��6�   $��142,134,0,0q�6�   $
 Wrap=�6�   $	��Top=�6�   $	��200��6�   ��6#   �� *	Contact+$ TwoWay=�$ PropertyChanged=�6�   �� 5   
   -   5        $��btnRegister��5   6   
����  �
�������$��Register��6I   $��16(�6\   $
��Left=�6j   $��530,178,0,0q�6�   $	��Top=�6�   $	��220��6�   $��30��6�   ��6�   �� *AddNewUserClick+$ TwoWay=�$ PropertyChanged=��� 5   
   $��470,125,0,0q�6   $��30��6%   $	��210��61   .��5      �� 
���   � �� CommandParameter 6+   �� 	 �� ElementName$	 RegisterWindow��
 �� Command
 6c   �� *OpenLoginClick+$ TwoWay=�$ PropertyChanged=�.�6�   %#Already Member? Click here to Login6�   5       5!      5"      