   M S B A M L   `   `   `  ����N  JBlowFish Cypher App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BlowFish_Cypher_AppBlowFish_Cypher_App  5   	   $    BlowFish_Cypher_App.PBoxWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BlowFish_Cypher_App     5   	     � Title$  
PBoxWindow��5   	   $	��528��6   $	��497��6)    � 
ResizeMode$ NoResize=�65   .��5	      � $	��506��6   $��	10,0,10,0q�6   .+�5
   
   �� -   5         ��Name$ image��5
      $��XOR-gate.png��6    $��30,-103,55,166q�66   �� 5   
   -   5        $ whiteSquare��5      $��white_square.png��6%   $	��100��6?   $��126,-6,251,462q�6K   �� 5   
   -   5         ��Name$ PboxTextBox_before��5      $�� ��6.    �� TextWrapping$
 Wrap=�66   $��18,129,371,81q�6J   �� 5   
   -   5        $ PboxTextBox_after��5      $�� ��6-   $
 Wrap=�66   $��368,129,16,81q�6J   �� 5   
   -   5        $ 
keyTextBox��5      $�� ��6&   $
 Wrap=�6.   $��107,24,63,442q�6B   �� 5   
   -   5         ��Name$ XOR_TextBlock��5      $1��+ P[i] ⊕ (i+1)th 32-bits of Key = new P[i]��6+   $
��Wrap=�6\   $��20(�6p   $��Center=�6~   $��0,218,0,153q�6�   $	��216��6�   �� 5   
   -   5         ��Name$ 
nextButton��5      $
��Next��6%   $��156,389,156,92q�6M   �� 5   
   -   5        $ 
skipButton��5      $��Skip to end��6%   $��156,427,156,53q�6T   �� 5   
   -	   5        $ finishButton��5      $��Return��6'   ${�False��68   $y�Hidden=�6e   $��156,389,156,92q�6z   �� 5   
   -
   5         ��Name$ label��5      $y�Visible=�6   $��Black"�64   $��P Box��6G   $��30,90,323,283q�6X   �� 5   
   -   5        $ 
label_Copy��5      $��	New P Box��6$   $��Black"�68   $��368,90,-41,266q�6K   �� 5   
   -   5        $ label_Copy1��5      $��
Binary Key��6%   $
��Left=�6:   $��Black"�6U   $��13(�6h   $��13,25,0,356q�6v   5      5      