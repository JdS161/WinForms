   M S B A M L   `   `   `  ����J  FCW_20220619_WPF, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null1clr-namespace:CW_20220619_WPFCW_20220619_WPF  5   	        CW_20220619_WPF.MainWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   /localclr-namespace:CW_20220619_WPF     5   	     � Title$  
MainWindow��5   	   $	��300��6   $	��300��6)   .��5P      �  � RowDefinitions 5Q   
   �� 5R      $
��Auto �6   �� 5S      $��5 �6   �� 5T      .+�5V   
   �� $��0��6   $��Transactions��6!    K� Capitals$ 	SmallCaps=�65   �� 5W   
   $��2��6   $��Stretch=�6   ��6=   �� *Transactions+��5Y      �� 5Z      .R�5[      �  � ColumnDefinitions 5\      �� 5]      �� 5^      $
��Auto �6/   .+�5`      �� $��0��6$   $
��Left=�6Q   ��64   �� *Description+6Q   �� 5a       ��Name$ priceTextBlock��6$   $��1��6<   $
��Bold"�6L   $��Right=�6^   ��6z   �� *Price+ �� Mode$ OneWay=� �� StringFormat$ {0:0.00}��5b       �� Triggers 5c      ^� 5d       ^� 
Conditions 5e      �� 5f   "   	 �� Binding	 6,   �� *	IsExpense+
 �� Value
 True6J   �� 5g   "   	 6,   �� *IsExpenseAllowable+	
 False6T   0�5i      �� 5j   "    �� 
TargetName$ priceTextBlock��6)    �� Property � �� �� Value
 � ���6e   5l      ^� 5m       5n      �� 5o   "   	 6,   �� *	IsExpense+
 True6J   �� 5p   "   	 6,   �� *IsExpenseAllowable+
 True6S   0�5r      �� 5s   "   $ priceTextBlock��6)    � ��
 �  ��6e   5u      �� 5v       �� Value$
 True��6C    �� Binding 6&   �� *
IsIncome+.a�5w      �� $ priceTextBlock��6%    � ��
 � � �6a   5x      5z      5|      5}      5�      