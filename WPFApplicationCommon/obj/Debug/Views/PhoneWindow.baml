   M S B A M L   `   `   `  ����O  KWPFApplicationCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPFApplicationCommon.ViewsWPFApplicationCommon.Views  5      ,    &WPFApplicationCommon.Views.PhoneWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WPFApplicationCommon.Views     5      $	��250��5      $	��800��6     � 	Resources  5	       �� 
TargetType �� Property �� Value��%�   '��       '�� G     �� 5
   
   " ��6   .�5      ��  � ��$ 8q�6'   5      �� 5   
   " ��6   .�5      ��  � ��$ 8q�6'   5      5      .��5      � $��0,0,0,18q�6    � RowDefinitions 5   
   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6   �� 5      $��50 �6    � ColumnDefinitions 5   
   �� 5      $	��100 �6   �� 5      .+�5   
   �� $��Модель��6   �� 5   
   $��Категория��6   $��1��6%   �� 5   
   $��Цена��6   $��2��6    �� 5    
   $��1��6)   ��6   �� *Title+6)   �� 5!   
   $��1��6,   $��1��6<   ��6   �� *
Category+6<   �� 5"   
   -   5        $��1��5"      $��2��6#   .��6Q   ��5#      �� 5$       �� Path$ Price�6    �� NotifyOnValidationError .  �� ValidationRules 5%      5  /System.Windows.Controls.DataErrorValidationRule  5&      5(      .��5)      5*      �� 5,   
   $��Center=�6   	 �� Orientation$	 
Horizontal=�62   $��3��6K   $��1��6X   $��276,0,276,10q�6h   .+�5-      �� -   5        
 �� 	IsDefault
 . $��60��5-   ;   $��5q�6I   .��6T   OK6X   �� 5.       �� IsCancel . $��60��6%   $��5q�63   .��6>   Отмена6F   5/      50      51      