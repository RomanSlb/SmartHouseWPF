   M S B A M L   `   `   `  ����B  >WpfApp3, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null!clr-namespace:WpfApp3WpfApp3  5   	       WpfApp3.Climat   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   'localclr-namespace:WpfApp3     5   	     � Title$  Climat��5   	   $	��390��6   $	��525��6%   
���   �.��5
      �� 
���/��� �� CornerRadius$ 20��6&   $��20q�68   ._�5   
   �� .+�5      �� $��Climat Controll��6   
��� � �$��15(�6A   �� 5      $A��; Choose the temperature you want to set in your Smart house��6   
��� � �6[   �� 5      6   �� 5      $��Temperature��6   
��� � �6*   �� 5      -   5        $��txtTemperature��5      ���#2F2936
�������$��18(�6T   $��
10,0,190,0q�6�   �� 5      -   5        $��slider��5       � Minimum$ 15Q�6T    � Maximum$ 30Q�6a    �� SelectionStart$ 0Q�6n   $��30��6�    �� IsSelectionRangeEnabled . $��10q�6�    � Value 6$   ��  �� Path$ BoundNumber� �� Mode$ TwoWay=�6�   �� 5      -   5        $��btnSet��5      $	��Set��68   $��120,10q�6F   
��� E��
�������$��18(�6�   $��42��6�   �� 5      -   5        $��btnBack��5      $
��Back��6:   $��120,50q�6I   ���#2F2936
�������$��18(�6�   $��42��6�   5      5      5      