   M S B A M L   `   `   `  ����D  @KINOPOISK, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:KINOPOISK	KINOPOISK  5   	       KINOPOISK.Player   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:KINOPOISK     5   	   -   5          � Title$  Player��5   	   $	��500��6   $	��800��6%    � 	Resources 5	         MyButtonStyle �� 
TargetType �� Property �� Value �� 
TargetType��%  &	        �� 5
   
   " ��6&   .�5      ��  � ��
 ���� 6+   �� 5       � �� 5      �� 5      " ��6&   .R�5      �� ��6!   Z� ��67   Z� ._�5      � .+�5   "   �� 5      5      5      5      5      5      .��5      �  � RowDefinitions 5   
   �� 5      $	��50* �6   �� 5      $
��400* �6   �� 5      $	��50* �6   .+�5!   
   r� -   5         r�Name$ VideoControl��5!   D    r� Stretch$
 Fill=�6   $��0��6&   $��3��63   	 r� LoadedBehavior$	 Manual=�6Z   
 r� UnloadedBehavior$

 Stop=�6r   6�   �� 5#   
   -   5         ��Name$ exitBtn��5#   8   #��[  6   $��0��6I   $	��Top=�6V   $
��Left=�6n   $��	10 10 0 0q�6�   $��30��6�   $��30��6�   .��5$      �� $	��←��6   $��20(�6!   $��Center=�6/   $��Center=�6J   $��0 0 0 5q�6g   
�������6x   5%      �� 5'   
   -   5         ��Name$ slider2��5'      $��2��6"   $��20��6/   $��Bottom=�6;   $��0 0 0 30q�6V    J� Opacity$	 0.5Q�6h   6v   �� 5)   
   -   5         ��Name$	 bar��5)      $��2��6"   $��Bottom=�6/    �� Orientation$ 
Horizontal=�6J   .+�5*      �� -   5        $ 
PlayButton��5*   3   $��33��6   $��15 0 0 0q�6!   $��45��6G   #��[  6d   .��5+      �� $��Center=�6   $��Center=�67   $	��►��6T   $��20(�6]   
�������6k   5,      �� 5-      -   5        $ PauseButton��5-   2   $��33��6   $��0 0 0 0q�6!   $��45��6G   #��[  6e   .��5.      �� $��Center=�6   $��Center=�67   $��▐▐��6T   $��12(�6^   
�������6l   5/      50      �� 51   
   -   5        $ fullScreenButton��51   W   $��33��6   $��Bottom=�6   $��2��68   $��0 0 15 0q�6E   $��Right=�6q   $��50��6�   #��[  6�   .��52      �� $��Center=�6   $��Center=�63   $	����6P   $��20(�6Y   
�������6g   53      54      55      