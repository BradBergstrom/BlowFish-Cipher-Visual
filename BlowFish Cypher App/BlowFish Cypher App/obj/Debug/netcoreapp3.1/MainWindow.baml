   M S B A M L   `   `   `  ����N  JBlowFish Cypher App, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null9!clr-namespace:BlowFish_Cypher_AppBlowFish_Cypher_App  5   	   $    BlowFish_Cypher_App.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   3local!clr-namespace:BlowFish_Cypher_App     5   	     � Title$  
MainWindow��5   	   $	��492��6   $
��1118��6)   .��5	      � $	��450��6   .+�5
   
   �� $��241,78,29,23q�6   
���   �6*   �� 5   
   $
��Left=�6   $	��349��6/   $��	25,78,0,0q�6<   
���   �$	��Top=�6^   $	��211��6v   �� 5   
   -   5         ��Name$ plainTextBox��5      $
��Left=�6(   $	��281��6C   $��259,129,0,0q�6P   $�� ��6e    �� TextWrapping$
 Wrap=�6m   $	��Top=�6�   $	��294��6�   �� 5   
   -   5        $ cipherTextBox��5      $��748,129,49,40q�6)   $�� ��6@   $
 Wrap=�6H   �� 5   
   -   5         ��Name$ plaintextLabel��5      $��25(�6(   $��	Plaintext��66   $
��Left=�6J   $��41��6e   $��
259,83,0,0q�6q   $	��Top=�6�   $	��330��6�   �� 5   
   -   5        $ chipertextLabel��5      $��25(�6)   $��
Ciphertext��67   $
��Left=�6L   $��41��6g   $��
748,83,0,0q�6s   $	��Top=�6�   $	��331��6�   �� 5   
   -   5         ��Name$ encryptButton��5      $��
Encrypt ->��6(   $
��Left=�6=   $��32��6X   $��572,187,0,0q�6d   $	��Top=�6y   $	��159��6�   6�   �� 5   
   -   5        $ decryptButton��5      $��
<- Decrypt��6(   $
��Left=�6@   $��34��6[   $��572,239,0,0q�6g   $	��Top=�6|   $	��159��6�   6�   �� 5   
   -   5        $ keyLabel��5      $
��Key:��6"   $��25(�61   $
��Left=�6?   $��50��6Z   $��	38,83,0,0q�6f   $	��Top=�6y   $��58��6�   �� 5   
   -   5        $ 
keyTextBox��5      $
��Left=�6&   $��15(�6A    �� TextAlignment$
 Left=�6O   $��79��6d   $��
38,133,0,0q�6p   $�� ��6�   $
 Wrap=�6�   $	��Top=�6�   $	��186��6�   �� 5   
   -	   5        $ 
titleLabel��5      $��Blowfish Cipher��6$   $��35(�6>   $��Center=�6L   $��Center=�6p   $��57��6�   $��0,10,0,0q�6�   $	��Top=�6�   $	��470��6�   �� 5   
   -
   5         ��Name$ showProcessCheckBox��5      $��Show Process��60   $
��Left=�6G   $��32��6b   $��577,289,0,0q�6n   $	��Top=�6�   $	��148��6�   �� 5   
   -   5        $ 
keyButton1��5      $��Generate P[] Box��6%   $
��Left=�6W   $��34��6r   $��
56,240,0,0q�6~   $	��Top=�6�   $	��150��6�   5      5      