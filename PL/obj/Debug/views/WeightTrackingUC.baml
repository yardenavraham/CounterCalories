   M S B A M L   `   `   `  ����=  9PL, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullclr-namespace:PLPL  5      O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e0891&clr-namespace:System;assembly=mscorlibSystem 5      b ^Syncfusion.SfChart.WPF, Version=17.4460.0.41, Culture=neutral, PublicKeyToken=3d67ed1f87d44c89eGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPFSyncfusion.UI.Xaml.Charts 5	      J FCounterCalories, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null0)clr-namespace:BE;assembly=CounterCaloriesBE 5
      clr-namespace:PLPL  5          PL.views.WeightTrackingUC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      U QMaterialDesignThemes.Wpf, Version=2.6.0.325, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5      localclr-namespace:PL  5      3System&clr-namespace:System;assembly=mscorlib  5      X
syncfusionGclr-namespace:Syncfusion.UI.Xaml.Charts;assembly=Syncfusion.SfChart.WPF  5	      3enm)clr-namespace:BE;assembly=CounterCalories  5
      local1clr-namespace:PL  5      -   5          >�Name$  Parent��5   7    � 	Resources 5         enmMeal S� 
MethodName S� 
ObjectType  System.Enum S� MethodParameters M� TypeName  PL.FieldsToWeight  fieldsToWeight��%�   &	        &	 k     S� 5   
   $ 	GetValues��6-   "  6D    5      M� 5      $ 	enm:EMeal��6   60   5        5   
   6    5      .��5      � -   5         �Name$ 	panelShow��5      $��Bottom=�6   $	��500��69   $��RightToLeft=�6F   ��5   
   �� 5       �� ImageSource$% /PL;component/Assets/Leaves.jpg��6   .+�5   
   �� $��WEIGHT
TRACKING��6   $��AR CENA)�63   $��45(�6H   $��157,60,10,311q�6V   $��LeftToRight=�6m   $��Italic$�6�   ��5      �� 5       �� EndPoint$ 0.5,1&�6&   	 �� 
StartPoint$	 0.5,0&�67   .��5      � 
 � Color$
 Black��6#    � Offset$ 0Q�61   � 5       $
 	#FF77CF93��6#   $ 1Q�65   5!      5#      '  !Syncfusion.UI.Xaml.Charts.SfChart  5$   
   -   5          Name$ SplineChart��5$      $	��318��62   $��22(�6>   
���   �$��Center=�6`   $��LeftToRight=�6~   $��
4,90,28,28q�6�      	Behaviors 5&      4  .Syncfusion.UI.Xaml.Charts.ChartZoomPanBehavior  64      PrimaryAxis 5)      ,  &Syncfusion.UI.Xaml.Charts.CategoryAxis  5*      )  #Syncfusion.UI.Xaml.Charts.ChartAxis   LabelsIntersectAction$
 Auto=�6+      ShowTrackBallInfo .    Header$	 Day��6a   
���   �6n      SecondaryAxis 5,      -  'Syncfusion.UI.Xaml.Charts.NumericalAxis  5-         RangePadding$ 
Additional=�6+   $ 
Lost Grams��6G   
���   �$��LeftToRight=�6n      Series. 50      ,  &Syncfusion.UI.Xaml.Charts.SplineSeries  /	  )Syncfusion.UI.Xaml.Charts.ChartSeriesBase 	  XBindingPath$	 day��6C   ,
  &Syncfusion.UI.Xaml.Charts.XyDataSeries 
  YBindingPath$ 	lostGrams��6V    	  EnableAnimation .  	  ShowTooltip . ,  &Syncfusion.UI.Xaml.Charts.ChartTooltip   EnableAnimation .  	  ItemsSource 6&   �� *Data+/  )Syncfusion.UI.Xaml.Charts.AdornmentSeries   AdornmentsInfo 51      2  ,Syncfusion.UI.Xaml.Charts.ChartAdornmentInfo  52      6  0Syncfusion.UI.Xaml.Charts.ChartAdornmentInfoBase   Symbol$ Ellipse=�64      	ShowLabel .    
ShowMarker .    LabelTemplate 53      �� 54      .R�55   "   � .+�56   &   A� ���	#FF1BA1E2$��35��6?   $��35��6K   $��0��6V   57   '   �� 58   &   
�������$��Segoe UI)�6T   $��14(�6j   $��Center=�6x   $��Center=�6�   ��60   �� 6�   59   #   5:      5<      5>      5?      5A      5B      