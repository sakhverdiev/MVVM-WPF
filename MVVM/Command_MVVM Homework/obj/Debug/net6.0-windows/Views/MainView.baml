   M S B A M L   `   `   `  ����P  LCommand_MVVM Homework, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullS.clr-namespace:Command_MVVM_Homework.ViewModels Command_MVVM_Homework.ViewModels  5   	   *    $Command_MVVM_Homework.Views.MainView   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @local.clr-namespace:Command_MVVM_Homework.ViewModels     5   	     � Title$  MainView��5   	   $	��450��6   $	��800��6'   .��5	      � .+�5   
   �� .+�5      �� -   5        $��CarBox��5      $
��Left=�6%   $��150 70 0 20q�6@   $	��400��6U   $��12(�6�   $
��Bold"�6  ��6b   �� *Cars+ �� UpdateSourceTrigger$ PropertyChanged=� �� SelectedItem 6�   �� *SelectedCar+ �� Mode$ TwoWay=�$ PropertyChanged=�6  �� 5      $��Maker��6   $
��Bold"�6%   $	��370��67   �� 5      ${�False��6   $��200 0 300 0q�6{   ��6(   �� *SelectedCar.Maker+$ TwoWay=�$ PropertyChanged=�6{   �� 5      $��Model��6   $
��Bold"�6%   $	��370��67   �� 5      ${�False��6   $��200 0 300 0q�6{   ��6(   �� *SelectedCar.Model+$ TwoWay=�$ PropertyChanged=�6{   �� 5      $
��Year��6   $
��Bold"�6$   $	��370��66   �� 5      ${�False��6   $��200 0 300 0q�6{   ��6(   �� *SelectedCar.Year+$ TwoWay=�$ PropertyChanged=�6{   �� 5      $��Engine��6   $
��Bold"�6&   $	��370��68   �� 5      ${�False��6   $��200 0 300 0q�6L   ��6(   �� *SelectedCar.Engine+6L   �� 5       �� Orientation$ 
Horizontal=�6   $��Center=�62   $��0 30 0 0q�6O   $	��522��6a   .+�5      �� $
��Show��6   
���   �$��80��6;   $��30��6F   $��0 0 40 0q�6R   ��6d   �� *ShowCommand+�� 5      $
��Save��6   
���   �$��80��6;   $��30��6F   $��0 0 30 0q�6R   ��6d   �� *SaveCommand+�� 5      $
��Edit��6   
���   �$��80��6;   $��30��6F   $��0 0 30 0q�6R   ��5      ��  �� RelativeSource �� *FindAncestor+ �� AncestorType" ���5   /   �� *EditCommand+�� 5      $��Delete��6   
���   �$��80��6=   $��30��6H   $��	0 0 100 0q�6T   ��6g   �� *DeleteCommand+5       5!      5"      5#      