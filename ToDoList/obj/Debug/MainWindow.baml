   M S B A M L   `   `   `  ����C  ?ToDoList, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null#clr-namespace:ToDoListToDoList  5   	       ToDoList.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   (localclr-namespace:ToDoList     5   	     � WindowStartupLocation$  CenterScreen=�5   	    � Title$ ToDoList��5	   	   $	��450��6   $	��800��6(   .��5
      �  � ColumnDefinitions 5   
   �� 5      $��* �6   �� 5      $
��auto �6   .+�5   
   �� $��0��6    �� Orientation$ Vertical=�6&   
�������.+�5      �� $��Center=�6   $��Right=�66   $ 
Horizontal=�6U   
�������.+�5      �� -   5        $��menuElohozas��5   %   
���   �$��1q�5   -   $y�	Collapsed=�6A   $	��|||��6X   $��30(�6f   $��5q�5      $��10q�6%   
������ $��50��5      6%   5      �� 5      $ 
Horizontal=�6   $��Center=�62   $
��Left=�6M   $��	20 10 0 0q�6h   .+�5      �� -   5        $��hozzadassav��5      $y�	Collapsed=�6-   
�������$��3q�6W    �� CornerRadius$ 5��6k   ._�5      �� -   5        $��bevitel��5      $��73��6-   $	��Top=�69    �� TextWrapping$
 Wrap=�6[   $��Add meg a feladatot��6o   $��5q�6�   $	��300��6�   6�   5      �� 5      -   5        $��hozzadasGomb��5!      
��� d �$��5q�5   3   $y�	Collapsed=�6G   $��Hozzáadás��6^   $��15(�6r   $��10q�5       $��10q�6&   
��� � �
�������$
��Bold"�6X   5!      �� 5"      -   5        $��	megseGomb��5$      
���**��$��5q�5"   /   $y�	Collapsed=�6C   $��Törles��6Z   $��15(�6k   $��10q�5#      $��10q�6*   
���  ��
�������$
��Bold"�6Z   5$      5%      �� 5*      -   5        $��feladatoksav��5*   V   $��20q�6   $ Vertical=�6&   
�������5+      53      �� 54   
   -   5        $
��menu��54   &   
���   �$��2��62   $��2,0,0,0q�6C   ._�55      �� $y�Visible=�6   $��Right=�6/   $ Vertical=�6L   
�������.+�56      �� -   5        $��bezaras��56   %   $��X��6   $
��Left=�64   $��5q�6O   $��Black"�6Z   
���  ��
������ 
������ 6�   �� 57      -	   5        $��	keresoSav��57   j   $ NoWrap=�6   $	��100��60   $��Keresés��6<   $��5q�6K   $��Black"�6W   $y�	Collapsed=�6{   
�������
�������6�   �� 58      -
   5        $��hozzadas��58   -   $��Hozzáadás��6   $��5,20,5,5q�6=   $��Black"�6O   
�������
������ 6�   �� 59      -   5        $��kereses��59   6   $��Keresés��6   $��5q�6+   $��Black"�6E   
�������
������ 6�   �� 5:      -   5        $��torles��5:   H   $��Törlés��6   $��5q�6*   $��Black"�65   
�������
������ 6�   �� 5;      -   5        $��keszFeladatok��5;   N   $��Kész feladat��6   $��5q�60   $��Black"�6;   
�������
������ 6�   �� 5<      -   5        $��nemKeszfeladatok��5=      $��Hiányzo feladat��5<      $��5q�63   $��Black"�6>   
�������
������ 5=   ^   5A      5B      5E      5F      