   M S B A M L   `   `   `  ����K  GDatabaseExample2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:DatabaseExample2DatabaseExample2  5   	   !    DatabaseExample2.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:DatabaseExample2     5   	     � Title$  Employee Info��5   	   $	��450��6   $	��800��6,   .��5	      � .+�5
   
   �� -   5         ��Name$ lblEmpNo��5
      $��Employee Number��6"   $
��Left=�6<   $��	92,65,0,0q�6W   $	��Top=�6j   $	��113��6�   �� 5   
   -   5        $ 
lblEmpName��5      $��Employee Name��6$   $
��Left=�6<   $��
92,125,0,0q�6W   $	��Top=�6k   $	��113��6�    J� RenderTransformOrigin$ 0.522,-0.769&�6�   z�5      V� 5      .~�5      �� �� 5       �� AngleX$ -1.364Q�6$   �� 5      T� 5       T� X$ 1.095Q�6)   5      5      �� 5   
   -   5        $ lblEmpSalary��5      $��Employee Salary��6&   $
��Left=�6@   $��
92,178,0,0q�6[   $	��Top=�6o   $��98��6�   �� 5   
   -   5        $ 
lblEmpDept��5      $��Employee Department��6$   $
��Left=�6B   $��
92,226,0,0q�6]   $	��Top=�6q   $	��135��6�   $��35��6�   �� 5   
   -   5         ��Name$ txtEmpNo��5      $
��Left=�6$   $��23��6?   $��
242,65,0,0q�6K    �� TextWrapping$
 Wrap=�6_   $�� ��6s   $	��Top=�6{   $	��180��6�   �� 5   
   -   5        $ 
txtEmpName��5      $
��Left=�6&   $��23��6A   $��242,127,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��180��6�   �� 5   
   -   5        $ 	txtEmpSal��5      $
��Left=�6%   $��26��6@   $��242,178,0,0q�6L   $
 Wrap=�6a   $�� ��6u   $	��Top=�6}   $	��180��6�   �� 5   
   -   5        $ 
txtEmpDept��5      $
��Left=�6&   $��23��6A   $��242,238,0,0q�6M   $
 Wrap=�6b   $�� ��6v   $	��Top=�6~   $	��180��6�   �� 5   
   -	   5        $	��ADD��5      $
��Left=�6   $��130,300,0,0q�6:   $	��Top=�6O   $	��112��6g   $��29��6s   6   �� 5   
   -
   5        $��Transaction��5      $
��Left=�6'   $��285,300,0,0q�6B   $	��Top=�6W   $	��156��6o   $��29��6{   6�   �� 5   
   -   5        $��Scalar Display��5      $
��Left=�6*   $��130,355,0,0q�6E   $	��Top=�6Z   $	��112��6r   $��35��6~   6�   5      5       