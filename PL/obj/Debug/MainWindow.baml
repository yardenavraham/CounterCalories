   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5   	   clr-namespace:PLPL  5   	       PL.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   "localclr-namespace:PL     5   	   U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   local1clr-namespace:PL  5   	     � Title$  Login��5	   	   $	��500��6   $	��350��6$    � 
ResizeMode$ NoResize=�5
   	    � WindowStartupLocation$ CenterScreen=�5   	    � WindowStyle$
 None=�5   	   $��Segoe UI Emoji)�5   	    � 	Resources 5      #   PL.FieldsToExistUserConverter   fieldsToExistUserConverter��%   &	          5   
   6Q   5      .��5      � -   5        $��	Container��5      .+�5   
   �� $��Assets/foodLove.jpg��6   $	��240��6-   $��Bottom=�6:   $��	0,0,0,260q�6U   $��UniformToFill=�6h   �� 5   
   $	��260��6   $	��Top=�6!   $��	0,240,0,0q�69   ��5      �� 5       �� EndPoint$ 0.5,1&�6&    �� 
StartPoint$ 0.5,0&�67   .��5      �  � Color$ 	#FF37431E��6#   � 5      $ 	#FFD1E8A4��6#    � Offset$ 1Q�65   � 5      $ 	#FF354918��6#   $ 0.546Q�65   5      5      �� 5   
   $	��280��6   $	��240��6    $��Bottom=�6-   $
��0,80q�6H   	 �� RadiusY$	 10��6V   
 �� RadiusX$
 10��6c   
������� J� Effect 5       3  -System.Windows.Media.Effects.DropShadowEffect  5!         
BlurRadius$ 15Q�6#      	Direction$ 0Q�63      RenderingBias$ Quality=�6A      ShadowDepth$ 1Q�6Y      Color$ 	#FFBBBBBB��6i   5#      � 5$   
   $��Bottom=�6   $��35,80q�6*   $	��240��69   .+�5%      �� $��LOGIN��6   $��Center=�6$   $��94,17,94,183q�6A   
�������$��24(�6i   $��Comic Sans MS)�6w   $��0q�6�   �� 5&      $��Center=�6   $��15q�64   .+�5'      �� -   5        $��userName��5'   (   $
��0,10q�6   )  #MaterialDesignThemes.Wpf.HintAssist   Hint$ 	User name��68    % !MaterialDesignFloatingHintTextBox#��[ 6c   $��Champagne & Limousines)�6�   $��18(�6�   G� 5(      -   5        $��password��5(   ,   $
��0,10q�6   $ Password��6<    ) %MaterialDesignFloatingHintPasswordBox#��[ 6f   $��Champagne & Limousines)�6�   $��18(�6�    G� 
CaretBrush �	#FF2196F36�   5)      5*      �� 5+   
   $��Sign in��6   $	��150��6E   $��Center=�6Q   $��Bottom=�6n   $
��0,65q�6�   ���	#FFF6F6F6���	#FF37431E
���������6#   �� *SignInCommand+��5,      `� 5-       `� 	Converter# [  6   .1�5.      ��  �� Path$
 Text�6    �� ElementName$ userName��6*   �� 5/      $ password��6   50      52      �� 53   
   -   5        $��	Container��53   .   $	��170��6K   $��Center=�6W   $��Bottom=�6t   $��
89,0,91,10q�6�   $��Register now��6�   
���   �$��Comic Sans MS)�6�   $��20(�6  $��40��6$  ��6   �� *
Register+��6�   Z� ��6�   Z� 60  55      56      