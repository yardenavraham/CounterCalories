   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      J FCounterCalories, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null0)clr-namespace:BE;assembly=CounterCaloriesBE 5	      clr-namespace:PLPL  5
          PL.UpdateWeight   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:PL  5      3System&clr-namespace:System;assembly=mscorlib  5      3enm)clr-namespace:BE;assembly=CounterCalories  5	      local1clr-namespace:PL  5
      -   5          >�Name$  Parent��5   7    � 	Resources 5         enmMeal S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  PL.FieldsToWeight  fieldsToWeight��%�   &	        &	 k     S� 5   
   $ 	GetValues��6-   "  6D    5      M� 5      $ 	enm:EMeal��6   60   5        5   
   6    5      .��5      � -   5        $��panelWeight��5      $	��459��6   $��RightToLeft=�6+   ��5   
   �� 5       �� ImageSource$% /PL;component/Assets/Leaves.jpg��6   .+�5   
   �� $��UPDATE
WEIGHT��6   $��AR CENA)�61   $��45(�6F   $��168,10,17,327q�6T   $��LeftToRight=�6k   $��Italic$�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      � 	 � Color$	 Black��6#   
 � Offset$
 0Q�61   � 5      $	 	#FF77CF93��6#   $
 1Q�65   5      5!      �� 5"   
   $��17,118,17,10q�6   $��LeftToRight=�6+   .+�5#      �� $��Current weight:��6   $��AR CENA)�6.   $��25(�6C   �� 5%      -   5         ��Name$ weight��5%      ���	#FFEEEDED$��35��6=    �� TextWrapping$
 Wrap=�6I   $��25(�6^   $��LeftToRight=�6l   $��AR CENA)�6�   $��0,0,14,0q�6�   �� 5&      $5��/How many grams do you want
 to lose this week?��6   $��AR CENA)�6V   $��25(�6k   $��75��6y   $��0,0,44,0q�6�   �� 5'      -   5        $ GramsToLose��5'      ���	#FFEEEDED$��35��6B   $
 Wrap=�6N   $��25(�6c   $��LeftToRight=�6q   $��AR CENA)�6�   $��0,0,14,0q�6�   �� 5)      $
��SAVE��65   $��LeftToRight=�6D   $��AR CENA)�6`   $��30(�6u   $��51��6�   ���	#FF6BBA84���	#FF476436$��
60,15,60,0q�6�   ��6   �� *SaveCommand+��5*      `� 5+       `� 	Converter# [ 6#   .1�5,      ��  �� Path$
 Text�6"    �� ElementName$ weight��6.   �� 5-      $
 Text�6"   $ GramsToLose��6.   5.      50      �� 51      $B��<     By clicking this button,
  your food data will be reset��6   $��AR CENA)�6_   $��25(�6t   $��81��6�   $��0q�6�   $	��272��6�   52      53      56      