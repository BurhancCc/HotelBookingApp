   M S B A M L   `   `   `  ����H  DAirBnbDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirBnbDesktopAirBnbDesktop  5   	        AirBnbDesktop.ViewBookings   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirBnbDesktop     5   	   -   5        $��View_Bookings��5         � Title$  ViewMyBookings��6	   $	��600��65   $
��1200��6B    � WindowStartupLocation$ CenterScreen=�6O   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�6-   $��35(�6H   $��View Bookings��6V   $
��Bold"�6n   �� 5   
   $��30(�6H   $��0��6V   $��20,10,10,10q�6c   $��	Main Menu��6�   $	��190��6�   $
��Left=�6�   ��6   ��  �� ElementName$ View_Bookings����6x   �� *MainMenuClick+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   &   System.Windows.Controls.DataGrid  5   
   -   5        $��
dgBookings��5   %  $��4��6�   $��20q�6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6  	 �� SelectedItem	 6   �� *SelectedBooking+$ TwoWay=�$ PropertyChanged=���6m   �� *
Bookings+$ TwoWay=�$ PropertyChanged=�
   Columns
 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Width5  /System.Windows.Controls.DataGridLengthConverter$ * 6%      
Visibility$ Hidden=�6/      
Foreground
 �   �   Header$ ID��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6b   �� *
EmployeeID+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ 
Start Date��6B    6V   �� *	StartDate+$ TwoWay=�$ PropertyChanged=� �� StringFormat$ 
dd-MM-yyyy��  5      $ * 6%   
 �   �$ End Date��6B    6T   �� *	EndDate+$ TwoWay=�$ PropertyChanged=�$ 
dd-MM-yyyy��  5      $ * 6%   
 �   �$ Booking Days��6B    6X   �� *BookingDays+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   
 �   �$ Total Charges��6B    6Y   �� *TotalCharges+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%      
IsReadOnly$
 True��6/   
 �   �$ Hotel��6T    6c   �� *HotelInfo.HotelName+$ TwoWay=�$ PropertyChanged=�  5      $ * 6%   $
 True��6/   
 �   �$ Room Id��6T    6e   �� *RoomId+$ TwoWay=�$ PropertyChanged=�4  .System.Windows.Controls.DataGridTemplateColumn  5      $ Update��6)   $ * 69      CellTemplate 5      �� 5      .R�5      �� -   5        $��Update��5   %   66   5      5         5!      $ Delete��6)   $ * 69    5"      �� 5#      .R�5$      �� -   5        $��Delete��5$   %   66   5%      5'      5*      5,      5-      