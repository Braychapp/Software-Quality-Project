   M S B A M L   `   `   `  ����D  @PlannerUI, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:PlannerUI	PlannerUI  5   	       PlannerUI.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5	   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5
   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:PlannerUI     5   	     � Title$  Planner window��5   	   $	��450��6    $	��800��6-   .��5      � $��0,0,691,405q�6    � RowDefinitions 5   
   �� 5      $	��14* �6   �� 5      $	��15* �6    � ColumnDefinitions 5   
   �� 5      $	��40* �6   �� 5      $	��69* �6   .+�5   
   �� $��1��6   $��139,67,-333,-88q�6$   $��1��6=   $
��Wrap=�6J   �� 6_    � Language$ en-ca�6c   $0�*Display the received orders from the Buyer��6t   6�   �� 5   
   -   5        $��Received Orders��5      $��407,67,-469,-88q�6+   $��1��6b   $��1��6o   �� 5   
   $��1��6   $��75,136,-333,-146q�6$   $��1��6>   $
��Wrap=�6K   $@��:Select carriers from targeted cities to complete the order��6_   $��25��6�   �� 5   
   -   5        $��Add Trips for Carriers��5      $��407,130,-469,-153q�62   $��1��6M   $��1��6]   $��25��6�   �� 5   
   -   5        $��Confirm Orders��5      $��407,194,-469,-217q�6*   $��1��6E   $��1��6U   $��25��6~   �� 5    
   $��1��6   $��202,200,-333,-210q�6$   $��1��6?   $
��Wrap=�6L   $$��Confirm the order is completed��6`   $��25��6�   �� 5"   
   $��1��6   $��110,275,-338,-298q�6$   $��1��6?   $
��Wrap=�6L   $9��3Display a summary of active orders in status screen��6`   �� 5#   
   -   5        $��Display Active Orders��5#      $��407,269,-469,-292q�61   $��1��6L   $��1��6\   $��25��6�   �� 5&   
   -   5        $��Generate Summary��5&      $��407,342,-469,-365q�6,   $��1��6G   $��1��6W   $��25��6�   �� 5'   
   $��1��6   $��54,343,-338,-365q�6$   $��1��6>   $
��Wrap=�6K   $B��<Generate a summary report for all data or the past two weeks��6_   5*      5+      