   M S B A M L   `   `   `  ����H  DAirBnbDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirBnbDesktopAirBnbDesktop  5   	   #    AirBnbDesktop.AvailableHotels   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirBnbDesktop     5   	   -   5        $��
ViewHotels��5   !     � Title$  AvailableHotels��6	   $	��600��63   $
��1200��6@    � WindowStartupLocation$ CenterScreen=�6M   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      $��80 �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�6-   $��35(�6H   $��View All Hotels��6V   $
��Bold"�6p   �� 5   
   $��30(�6E   $��0��6S   $��20,10,10,10q�6`   $��	Main Menu��6�   $	��190��6�   $
��Left=�6�   ��6   ��  �� ElementName$ 
ViewHotels����6u   �� *MainMenuClick+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��Center=�6   $��Center=�6-   $��35(�6H   $��1��6�   $
��Bold"�6�   ��6V   �� *
HotelExtra+$ TwoWay=�$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��dgHotels��5      $��4��6�   $��20q�6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6  	 �� SelectedItem	 6   �� *SelectedHotel+$ TwoWay=�$ PropertyChanged=���6j   �� *Hotels+$ TwoWay=�$ PropertyChanged=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
Visibility$ Hidden=�6/      
Foreground
 �   �   Header$ ID��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6b   �� *
EmployeeID+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ 
Hotel Name��6B    6V   �� *	HotelName+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ Rating��6B    6R   �� *Rating+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$
 City��6B    6P   �� *City+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ Country��6B    6S   �� *	Country+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ Number Of Rooms��6B    6[   �� *NumberOfRooms+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ 	Available��6B    6U   �� *IsAvailable+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Action��6)   $ * 69      CellTemplate 5      �� 5      .R�5       �� -   5        $��
View Rooms��5    %   6:   5!      5#      5&      5(      5)      