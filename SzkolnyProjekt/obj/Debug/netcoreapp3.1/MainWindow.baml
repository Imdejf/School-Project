   M S B A M L   `   `   `  ����I  ESzkolnyProjekt, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null;"clr-namespace:SzkolnyProjekt.ViewsSzkolnyProjekt.Views  5   	   ;"clr-namespace:SzkolnyProjekt.ViewsSzkolnyProjekt.Views  5   	       SzkolnyProjekt.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   4local"clr-namespace:SzkolnyProjekt.Views     5   	   7Controls"clr-namespace:SzkolnyProjekt.Views     5   	     � Title$  ToDoList��5
   	   $	��600��6   $	��400��6'    � 
ResizeMode$ NoResize=�63   .��5      � ��6   �� *CurrentColor+ � RowDefinitions 5   
   �� 5      $��60 �6   �� 5      $��* �6   .+�5   
   �� -   5         ��Name$ DateText��5   O   $��Right=�6   
���   �$��15(�6A   $
��Bold"�6a    �� TextAlignment$ Center=�6s   $	��Top=�6�   $	��150��6�   � 5   
   $��0��6    � ColumnDefinitions 5      �� 5      $	��150 �6#   .+�5      �� .+�5      �� $��0��6   .+�5      �� $��0q�6   $��1��6S   $��0q�6h   $��55��6|   $��55��6�   
������ ��6)   �� *UpdateBackgroundColor+.��5      A� $��50��6"   $��50��6-   
���   ���5      �� 5   "    �� EndPoint$ 0.5,1&�66    �� 
StartPoint$ 0.5,0&�6G   .��5   &   �  � Color$ 	#FF536B8F��63   � 5   &   $ 	#FF459FF9��63   	 � Offset$	 1Q�6E   5   #   5      5       5!      �� 5"      $��Center=�6   .+�5#      �� $��0q�6   $��2��6S   $��0q�6h   $��55��6|   $��55��6�   
������ ��6)   �� *UpdateBackgroundColor+.��5$      A� $��50��6"   $��50��6-   
���   ���5%      �� 5&   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��5'   &   � $ 	#FFFF7E58��63   � 5(   &   $ 	#FFF3EE7F��63   $	 1Q�6E   5)   #   5+      5,      5-      �� 5.      $��Right=�6   .+�5/      �� $��0q�6   $��3��6S   $��0q�6h   $��55��6|   $��55��6�   
������ ��6)   �� *UpdateBackgroundColor+.��50      A� $��50��6"   $��50��6-   
���   ���51      �� 52   "   $ 0.5,1&�66   $ 0.5,0&�6G   .��53   &   � $ 	#FFB4B4B4��63   � 54   &   $ 	#FFD452F1��63   $	 1Q�6E   55   #   57      58      59      5:      5;      � 5<   
   $��1��6   .+�5=      �� $
��Auto=�6    $��Disabled=�6C   .��5>      �� ��6%   �� *CurrentViewModel+5?      5@      5A      5C      