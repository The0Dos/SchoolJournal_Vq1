   M S B A M L   `   `   `  ����O  KSchoolJournalDesktop, Version=1.0.0.0, Culture=neutral, PublicKeyToken=nullG(clr-namespace:SchoolJournalDesktop.FormsSchoolJournalDesktop.Forms  5   	   *    $SchoolJournalDesktop.Forms.ZavWindow   5   	   W SPresentationCore, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35e aSystem.Windows.Controls.Ribbon, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089R NWindowsBase, Version=6.0.2.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=6.0.2.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   :local(clr-namespace:SchoolJournalDesktop.Forms     5   	     � Title$  	ZavWindow��5   	   $	��450��6   $	��800��6(   .��5	      � .+�5
   
   �� .+�5      �� $��10q�6    �� Orientation$ 
Horizontal=�6%   .+�5      �� $
��10 0q�6   $��Center=�6*   $��Учебный год:��6E   �� 5      -   5         ��Name$ cbYear��5   D    �� DisplayMemberPath$ BeginEnd��6   $	��100��68   6D   �� 5      $
��10 0q�6   $��Center=�6*   $(��"Учебное полугодие:��6E   �� 5      -   5        $ 
cbPoluYear��5      $	��100��6/   �� 5      $
��10 0q�6   $��Center=�6*   $��Класс:��6E   �� 5      -   5        $ cbClass��5   4   $
 Name��6   $��30��6E   �� 5      -   5        $��Применить��5      $
��10 0q�6>   �� 5      -   5        $��Сбросить��5      $
��10 0q�6<   5      &   System.Windows.Controls.DataGrid  5      -   5          Name$ 
dgStudents��5         
IsReadOnly$
 True��6+      AutoGenerateColumns$ False��6=      Columns 5      0  *System.Windows.Controls.DataGridTextColumn  5      ,  &System.Windows.Controls.DataGridColumn   Header$ ФИО��6)   1  +System.Windows.Controls.DataGridBoundColumn	   Binding	 66   �� *
FullName+  5      $ 
Класс��6)   	 68   �� *CurrentClass+  5      $ 
Адрес��6)   	 68   �� *	Address+  5      $ Телефон��6)   	 6:   �� *ParentTelephone+5      �� 5      $ 
Horizontal=�6   $��10 15q�62   .+�5      �� -   5        
 ��Name$
 tbAvg��5      $/��)Средняя успеваемость: ��6+   5      5       5!      5"      