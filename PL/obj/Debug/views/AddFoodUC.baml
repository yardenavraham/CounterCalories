   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      J FCounterCalories, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null0)clr-namespace:BE;assembly=CounterCaloriesBE 5	      -clr-namespace:PL.ConvertersPL.Converters  5
          PL.AddFoodUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:PL  5      3System&clr-namespace:System;assembly=mscorlib  5      3enm)clr-namespace:BE;assembly=CounterCalories  5	      (local1clr-namespace:PL.Converters  5
        � 	Resources  5         enmMeal S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName 
 enmDay)   #PL.Converters.FieldsToFoodConverter  fieldsToFoodConverter��%  &	        &	 k     &	 �     S� 5   
   $ 	GetValues��6-   "  6D    5      M� 5      $ 	enm:EMeal��6   60   5      S� 5   
   $ 	GetValues��6,   "  6C    5      M� 5      $ System:DayOfWeek��6   67   5        5   
   6'   5      .��5      � -   5        $��AddFoodGrid��5      $	��500��6   $��RightToLeft=�6+   ��5   
   �� 5       �� ImageSource$% /PL;component/Assets/Leaves.jpg��6   .+�5    
   �� $��ADD FOOD��6   $��AR CENA)�6#   $��60(�68   $��111,25,10,390q�6F   $��LeftToRight=�6]   $��Italic$�6y   ��5!      �� 5"       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5#      �  � Color$ Black��6#   	 � Offset$	 0Q�61   � 5$      $ 	#FF77CF93��6#   $	 1Q�65   5%      5'      �� 5(   
   $��17,115,17,10q�6   $��LeftToRight=�6+   .+�5)      �� $��Search:��6   $��AR CENA)�6&   $��25(�6;   $��52��6I      PL.AutoCompleteUC  5*      -   5        
  Name$
 search_food��5*   #   $
��Left=�68   $��Center=�6S   $��35��6n   $	��300��6z   $��25(�6�   $��LeftToRight=�6�   ���	#FFEEEDED6�   �� 5+      $��Amount:��6   $��AR CENA)�6&   $��25(�6;   �� 5,      -   5         ��Name$ amount��5,      ���	#FFEEEDED$��35��6=    �� TextWrapping$
 Wrap=�6I   $��25(�6^   $��LeftToRight=�6l   $��AR CENA)�6�   $��0,0,14,0q�6�   �� 5-      $��Meal:��6   $��AR CENA)�6$   $��25(�69   �� 5.      -   5         ��Name$
 meal��5.      ���	#FFEEEDED & "MaterialDesignFloatingHintComboBox#��[ 6>   $��Champagne & Limousines)�6z   $��18(�6�   4  .System.Windows.Automation.AutomationProperties   Name$ 	mealCombo��6�   $��35��6  $��LeftToRight=�6  $��0,0,14,0q�66  ��6�   ��  �� Source# [  66  �� 5/      $
��SAVE��65   $��LeftToRight=�6D   $��AR CENA)�6`   $��30(�6u   $��51��6�   ���	#FF6BBA84���	#FF476436$��
60,15,60,0q�6�   ��6   �� *SaveCommand+��50      `� 51       `� 	Converter# [ 6#   .1�52      ��  �� Path$
 Text�6"    �� ElementName$ search_food��6.   �� 53      $
 Text�6"   $ amount��6.   �� 54      $ SelectedValue�6"   $
 meal��67   �� 55      $ SelectedValue�6"   $	 day��67   56      58      59      5:      5;      