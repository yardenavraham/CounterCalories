   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5   	   J FCounterCalories, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null0)clr-namespace:BE;assembly=CounterCaloriesBE 5	   	   clr-namespace:PLPL  5   	        PL.UserControls.RegisterUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   9System&clr-namespace:System;assembly=mscorlib     5   	   9enm)clr-namespace:BE;assembly=CounterCalories     5	   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5
   	   local1clr-namespace:PL  5   	   $��Segoe UI Emoji)�5   	   4  .System.Windows.Automation.AutomationProperties    IsRowHeader  .  � 	Resources 5         PL.FieldsToUserConverter   fieldsToUserConverter  	enmSports S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName��%�   &	        &	        5   
   6G   S� 5   
   $ 	GetValues��6/   "  6F    5      M� 5      $ enm:EActivityLevel��6   69   5      5      .��5      � -   5        $��registerGrid��5      .+�5   
   �� $
��Left=�6   $	��240��6+   $	��Top=�68   $	��353��6P   $'��!/PL;component/Assets/foodLove.jpg��6\   $��UniformToFill=�6�   �� 5   
   $	��260��6   $	��Top=�6!   $��	0,240,0,0q�69   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF37431E��6#   � 5      $ 	#FFD1E8A4��6#   	 � Offset$	 1Q�65   � 5      $ 	#FF354918��6#   $	 0.546Q�65   5      5!      �� 5#   
   $	��280��6   $	��451��6    $��Bottom=�6-   $��
36,0,37,25q�6H   
 �� RadiusY$
 10��6\    �� RadiusX$ 10��6i   
������� J� Effect 5$      3  -System.Windows.Media.Effects.DropShadowEffect  5%         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5'      � 5(   
   $��Bottom=�6   $��
35,0,35,20q�6*   $	��300��6>   .+�5)      �� $��Center=�6   $��10,-143,20,29q�64   $	��414��6K   .+�5*      �� -   5        $��userName��5*   �   $	��0,0q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	User name��6'    % !MaterialDesignFloatingHintTextBox#��[ 6R   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 5+      -   5        $
��name��5+   �   $	��0,0q�6   $
 Name��6'   #��[ 6M   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 5,      -   5        $��password��5,   �   $	��0,0q�6   $ Password��6'   #��[ 6Q   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 5-      -   5        $��	birthYear��5-   �   $	��0,0q�6   $ 
Birth year��6'   #��[ 6S   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 5.      -   5        $��height��5.   �   $	��0,0q�6   $ Height (Sm)��6'   #��[ 6T   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 5/      -   5        $��weight��5/   �   $	��0,0q�6   $ Weight (Kg)��6'   #��[ 6T   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 50      -   5        $��DestinationWeight��50   �   $	��0,0q�6   $# Grams to lose at week (grams)��6'   #��[ 6f   $��Champagne & Limousines)�6�   $��18(�6�   6�   �� 51      -	   5        $��gender��51   �   $	��0,0q�6   $ Gender��6(    & "MaterialDesignFloatingHintComboBox#��[ 6P   $��Champagne & Limousines)�6�   $��18(�6�   .@�52      �� $
��male��6#   �� 53      $��female��6#   54      �� 55      -
   5        $��
sportCombo��55   �   $	��0,0q�6   $ Sport��6(   #��[ 6O   $��Champagne & Limousines)�6�   $��18(�6�   ��6�   ��  �� Source# [ 56      59      5:      �� 5;   
   $��Sign up��6   $��153.9��6H   $��Center=�6V   $��Bottom=�6s   $��101,0,98,10q�6�   ���	#FFF6F6F6���	#FF37431E
���������6#   �� *AddSignUpCommand+��5<      `� 5=       `� 	Converter# [  6   .1�5>      ��  �� Path$
 Text�6    �� ElementName$ userName��6*   �� 5?      $
 Text�6   $
 name��6*   �� 5@      $
 Text�6   $ password��6*   �� 5A      $
 Text�6   $ 	birthYear��6*   �� 5B      $
 Text�6   $ height��6*   �� 5C      $
 Text�6   $ weight��6*   �� 5D      $
 Text�6   $ DestinationWeight��6*   �� 5E      $ SelectedIndex�6   $ gender��63   �� 5F      $ SelectedValue�6   $ 
sportCombo��63   5G      5I      �� 5J   
   -   5         ��Name$
 Back��5J      $
��Back��6    $��10,10,279,458q�6/   6F   5L      5M      