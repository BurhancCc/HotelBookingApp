   M S B A M L   `   `   `  ����H  DAirBnbDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:AirBnbDesktopAirBnbDesktop  5   	   "    AirBnbDesktop.ViewHotelRooms   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:AirBnbDesktop     5   	     � Title$  ViewHotelRooms��5   	   $	��600��6    $
��1000��6-   .��5	      �  � RowDefinitions 5
   
   �� 5      $��80 �6   �� 5      $��40 �6   �� 5      $��80 �6   �� 5      .+�5   
   �� $��Center=�6   $��Center=�6-   $��35(�6H   $��View Hotel Rooms��6V   $
��Bold"�6q   �� 5   
   $��1��6   $��20(�6g   $��Center=�6u   $��Center=�6�   
����  �$
��Bold"�6�   ��6   �� *Extra+ �� Mode$ TwoWay=� �� UpdateSourceTrigger$ PropertyChanged=�6�   �� 5   
   $��2��6   $��Booking From :��6   $
��Bold"�66   $
��Left=�6H   $��20,0,0,0q�6c   $��Center=�6u   $��20(�6�   $	��199��6�   (  "System.Windows.Controls.DatePicker  5   
   $��2��6   $
��Left=�6"   $��	230,0,0,0q�6=   $��Center=�6P   $��20(�6k   $	��190��6y      SelectedDate 6�   �� *SelectedStartDate+$ TwoWay=�$ PropertyChanged=��� 5   
   $��2��6   $��Booking To :��6   $
��Bold"�64   $��Center=�6F   $��	130,0,0,0q�6c   $��Center=�6v   $��20(�6�   $	��120��6�     5   
   $��2��6   $��Right=�6"   $��	0,0,100,0q�6>   $��Center=�6Q   $��20(�6l   $	��190��6z    6�   �� *SelectedEndDate+$ TwoWay=�$ PropertyChanged=�&   System.Windows.Controls.DataGrid  5   
   -   5        $��dgHotelRooms��5     $��3��6�   $��20q�6�      AutoGenerateColumns$ False��6�      CanUserAddRows$ False��6�      CanUserDeleteRows$ False��6   �� SelectedItem 6   �� *SelectedRoom+$ TwoWay=�$ PropertyChanged=���6i   �� *Rooms+$ TwoWay=�$ PropertyChanged=�	   Columns	 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn
   Width5  /System.Windows.Controls.DataGridLengthConverter$
 * 6%      
Visibility$ Hidden=�6/      
Foreground
 �   �   Header$ ID��6V   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6b   �� *
EmployeeID+$ TwoWay=�$ PropertyChanged=�  5      $
 * 6%   
 �   �$
 Size��6B    6P   �� *Size+$ TwoWay=�$ PropertyChanged=�  5      $
 * 6%   
 �   �$ Price Per Night��6B    6[   �� *PricePerNight+$ TwoWay=�$ PropertyChanged=�  5      $
 * 6%   
 �   �$ 	Available��6B    6U   �� *IsAvailable+$ TwoWay=�$ PropertyChanged=�  5       $
 * 6%   
 �   �$ Available Date��6B    6Z   �� *AvailableDate+$ TwoWay=�$ PropertyChanged=� �� StringFormat$ 
dd-MM-yyyy��5"      5$      5%      