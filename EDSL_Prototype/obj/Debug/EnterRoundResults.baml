   M S B A M L   `   `   `  ����I  EEDSL_Prototype, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null/clr-namespace:EDSL_PrototypeEDSL_Prototype  5      &     EDSL_Prototype.EnterRoundResults   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      .localclr-namespace:EDSL_Prototype     5        N� Title$  EnterRoundResults��5	       N� 
Background
 �����.��5      � .+�5   
    � -   5          �Name$
 Main��5      $
��Left=�6   $	��450��69   $	��Top=�6F   $	��780��6^     � NavigationUIVisibility$ Hidden=�6j   $��10,0,0,-0.4q�6�   $��2��6�   $��2��6�   �� 5   
   $
��Left=�6   $��
256,-2,0,0q�6/   $
��Wrap=�6C   $��Results��6W   $	��Top=�6f   $
��Bold"�6~   $��Italic$�6�   $��36(�6�   �� 5   
   $
��Left=�6   $��	10,62,0,0q�6/   $
��Wrap=�6B   $��	Round No:��6V   $	��Top=�6g   $
��Bold"�6   $��16(�6�   $��84��6�   �� 5   
   $
��Left=�6   $��
192,62,0,0q�6/   $
��Wrap=�6C   $��Game Results:��6W   $	��Top=�6l   $��16(�6�   $
��Bold"�6�   �� 5   
   -   5        $��Update Results��5      $
��Left=�6*   $��	0,123,0,0q�6E   $	��Top=�6X   $	��127��6p   $
��Bold"�6|   $��15(�6�   $��23��6�   ���	#FF4AFCF9 J� RenderTransformOrigin$ 0.221,0.681&�6�   6�   �� 5   
    �� 
IsEditable .  �� 
IsReadOnly .  �� Text$ SeasonNo��67   $
��Left=�6G   $��	99,35,0,0q�6b   $	��Top=�6u   $��77��6�   $��20��6�   $ -0.046,0.44&�6�   .@�5      �� $��Season 1��6   60   �� 5      $��Season 2��6   60   �� 5      $��Season 3��6   60   5      �� 5   
   $��Edit Results��6   $
��Left=�6(   $��	0,151,0,0q�6C   $	��Top=�6V   $	��127��6n   ���	#FF72FCF0$
��Bold"�6�   $��15(�6�   $��23��6�   �� 5   
   -   5        $��Save Results��5      $
��Left=�6(   $��	0,179,0,0q�6C   $	��Top=�6V   $	��127��6n   ���	#FF5EFDEF$
��Bold"�6�   $ -0.613,0.542&�6�   $��15(�6�   6�   �� 5   
   -   5        $��Calculate Ladder��5      $
��Left=�6,   $��	0,263,0,0q�6G   $	��Top=�6Z   $	��127��6r   $ 0.867,-0.193&�6~   ���	#FF54F9EA$
��Bold"�6�   $��15(�6�   6�   �� 5   
   -   5         ��Name$ btnCreateLadder��5      $��Create Ladder��6*   $
��Left=�6B   $��	0,207,0,0q�6]   $	��Top=�6p   $	��127��6�   $ 0.867,-0.193&�6�   ���	#FF54F9EA$
��Bold"�6�   $��23��6�   $��15(�6�   6�   �� 5   
   $
��Left=�6   $��	10,33,0,0q�6/   $
��Wrap=�6B   $��
Season No:��6V   $	��Top=�6h   $��16(�6�   $
��Bold"�6�   $ 0.486,-0.348&�6�   �� 5   
    .  . $ RoundNo��67   $
��Left=�6F   $��	99,64,0,0q�6a   $	��Top=�6t   $��77��6�   $��20��6�   .@�5      �� $��Round 1��6   6/   �� 5      $��Round 2��6   6/   �� 5      $��Round 3��6   6/   5       �� 5!   
   $��Update Ladder��6   $
��Left=�6)   $��	0,235,0,0q�6D   $	��Top=�6W   $	��127��6o   ���	#FF72FCF0$
��Bold"�6�   $��15(�6�   $ 0.535,2.483&�6�   &   System.Windows.Controls.DataGrid  5"   
   -   5        	  Name$	 DataLadderGames��5"   +   $
��Left=�6E   $	��231��6`   $��
132,89,0,0q�6m   $	��Top=�6�   $	��479��6�   ��6   �� 6�   5#      5$      