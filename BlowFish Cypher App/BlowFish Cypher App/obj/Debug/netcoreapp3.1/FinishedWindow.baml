   M S B A M L   `   `   `  ����N  JBlowFish Cypher App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BlowFish_Cypher_AppBlowFish_Cypher_App  5   	   (    "BlowFish_Cypher_App.FinishedWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BlowFish_Cypher_App     5   	     � Title$  FinishedWindow��5   	   $	��642��6    $	��800��6-    � 
ResizeMode$ NoResize=�69   .��5	      � $	��824��6    � ColumnDefinitions 5
   
   �� 5      $
��263* �6   �� 5      $
��537* �6   .+�5   
   �� -   5         ��Name$ image��5      $!��BlowFish Diagram part 2.png��6   $
��Left=�6D   $��112,40,0,166q�6_   $	��577��6u   $��2��6�   �� 5   
   -   5         ��Name$ cihperTextBox��5      $
��Left=�6)   $��234,461,0,0q�6D   $�� ��6Y    �� TextWrapping$
 Wrap=�6a   $	��Top=�6u   $	��333��6�   $	��140��6�   $��2��6�   �� 5   
   -   5         ��Name$ finLabel��5      $��Answer so far:��6"   $��25(�6;   $
��Left=�6I   $��143,410,0,0q�6d   $	��Top=�6y   $��46��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $	��238��6�   $��2��6�   6�   �� 5   
   -   5        $ p17label��5      $��P[17]��6"   $��25(�62   $
��Left=�6@   $��354,146,0,0q�6[   $	��Top=�6p   $��46��6�   $��72��6�   $��1��6�   �� 5   
   -   5        $ p16label��5      $��P[16]��6"   $��25(�62   $
��Left=�6@   $��118,146,0,0q�6[   $	��Top=�6p   $��50��6�   $��70��6�   �� 5   
   -   5         ��Name$ p16TextBlock��5      $��15(�6*   $��1��68   $
��Left=�6H   $��363,215,0,0q�6c   $��	TextBlock��6x   $
��Wrap=�6�   $	��Top=�6�   $��49��6�   $��96��6�   �� 5   
   -   5        $ p17TextBlock��5      $��15(�6*   $
��Left=�68   $��118,216,0,0q�6S   $��	TextBlock��6h   $
��Wrap=�6y   $	��Top=�6�   $��48��6�   $��96��6�   �� 5   
   -   5        $ inputLeftLabel��5      $��Label��6(   $
��Left=�68   $��
189,90,0,0q�6S   $	��Top=�6g   $��2��6   $	��204��6�   $��25��6�   �� 5   
   -	   5        $ inputRightLabel��5      $��Label��6)   $
��Left=�69   $��
135,90,0,0q�6T   $	��Top=�6h   $	��197��6�   $��1��6�   $��25��6�   �� 5   
   -
   5        $ label��5      $��Output Whitening��6   $��35(�6:   $
��Left=�6H   $��
262,17,0,0q�6c   $	��Top=�6w   $��2��6�   $	��305��6�   $��61��6�   5      5      