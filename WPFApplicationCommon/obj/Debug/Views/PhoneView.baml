   M S B A M L   `   `   `  ����O  KWPFApplicationCommon, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:WPFApplicationCommon.ViewsWPFApplicationCommon.Views  5      *    $WPFApplicationCommon.Views.PhoneView   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      :local(clr-namespace:WPFApplicationCommon.Views     5      P LPrism.Wpf, Version=6.3.0.0, Culture=neutral, PublicKeyToken=40ee6c3a2184dc59$prismhttp://prismlibrary.com/  5      !  Prism.Mvvm.ViewModelLocator    AutoWireViewModel  .  � 	Resources 5       �� 
TargetType �� Property �� Value��%�   '��       �� 5   
   " ��6   .�5      ��  � ��$ 	10 8 10 8q�6'   �� 5       � ��$	 100��6&   �� 5       � ��$ 30��6'   5      5      .��5      �  � RowDefinitions 5   
   �� 5      $��* �6   �� 5      $
��Auto �6   .+�5   
   &   System.Windows.Controls.DataGrid  -   5          Name$ 
phonesGrid��5   /      AutoGenerateColumns .     Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn	   Header$	 Модель��6?   
   Width5  /System.Windows.Controls.DataGridLengthConverter$	
 100 6O   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6%   �� *Title+6O     5      $	 Категория��6B   $	
 110 6U    6%   �� *
Category+6U     5      $	 Цена��6?   $
 70 6M    6%   �� *Price+6M   5      �� 5   
   $��Center=�6   $��1��63    �� Orientation$ 
Horizontal=�6@   .+�5       �� -   5         ��Name$ insertButton��5       $��Добавить��6+   6>   �� 5!      -   5        $ 
editButton��5!      $ ��Редактировать��6)   6A   �� 5"      -   5        $ updateButton��5"      $��Обновить��6+   6>   �� 5#      -   5        $ deleteButton��5#      $��Удалить��6+   6=   �� 5$      -   5        $ searchButton��5$      $��Выборка��6+   6=   �� 5%      -   5        $��cmbCategory��5%      $	��159��6*   $��0,10,0,8q�66   .@�5&      �� .��6   Mobile6'   �� 5'      .��6   
Stationary6+   �� 5(      .��6   All6$   5)      5*      5+      5,      