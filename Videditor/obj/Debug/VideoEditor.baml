   M S B A M L   `   `   `  ����D  @Videditor, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null%clr-namespace:Videditor	Videditor  5   	       Videditor.VideoEditor   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   )localclr-namespace:Videditor     5   	     � WindowState$  	Maximized=�5   	    � Title$! Видео редактор��6!   $	��450��68   $	��800��6E   .��5	      ]� .+�5
   
   o� $	��Top=�6   .@�5      m� $��Файл��6   .@�5      m� -   5        $+��%Импортировать видео��5      68   5      m� 5      $��Правка��6   5      m� 5      $��Хронометраж��6   .@�5      m� -   5        $��Рендер видео��5      61   m� 5      -   5        $(��"Продолжительность��5      66   m� 5      -   5        $%��Сменить качество��5      65   5      5      �� 5   
   -   5        $	��100��5   2   $��Bottom=�6?   
�����w�.+�5      �� -   5         ��Name$ timeline��5      $	��100��6'   +�5      �� 5      -   5         ��Name$ outsideStartArea��5       
���   � �� Left$ 0��6G   $	��100��6X   $��8��6e   �� 5       -   5        $��15��5        $��15��6+   ��5!      �� 5"       �� ImageSource$M Ghttps://cdn3.iconfinder.com/data/icons/neutro-interface/32/next-256.png��6)   5$      �� 5%      -	   5         ��Name$ timelineCursor��5%      
���   �	 �� X1$ 50��6B   	 �� Y1$ 0��6J   		 �� X2$	 50��6Q   	
 �� Y2$	
 100��6Y   �� 5&      -
   5        $ endTimelineMarker��5&       $
 1500��6;   $��15��6N   $��15��6Y   ��5'      �� 5(      $M Ghttps://cdn3.iconfinder.com/data/icons/neutro-interface/32/next-256.png��6*   5*      �� 5+      -   5        $ outsideEndArea��5+       
���   �$
 1000��6E   $��8��6X   $	��100��6b   5-      5.      ]� 5/   
   $	��Top=�6   
�������.+�50      �� $
��Left=�6   
�������$	��100��6A   52      �� 54      
���OO/�$
��Left=�64   .+�55      �� $	��550��6   $��Center=�6*   $
��1350��6E   .+�56      �� $��
5, 5, 5, 5q�6!    �� Orientation$ 
Horizontal=�65   $��Center=�6N   .+�57      �� -   5        $	��▶��57   !   $��
5, 5, 5, 5q�6-   $��35��6A   6L   �� 58      -   5        $	��⭰��58   !   $��
5, 5, 5, 5q�6-   $��35��6A   6L   �� 59      -   5        $	��⏸��59   !   $��
5, 5, 5, 5q�6-   $��35��6A   6L   �� 5:      -   5        $	��⭲��5:   !   $��
5, 5, 5, 5q�6-   $��35��6A   6L   5;      r� 5<      -   5         r�Name$ footage��5<   #    r� ScrubbingEnabled .  r� LoadedBehavior$ Manual=�6�    r� IsMuted . $
��1000��6�    r� Source$� �file:///C:/Users/%D0%9F%D0%9A/Downloads/%D0%A7%D0%B5%D0%BB%D0%BE%D0%B2%D0%B5%D0%BA-%D0%9F%D0%B0%D1%83%D0%BA%203_%20%D0%9D%D0%B5%D1%82%20%D0%9F%D1%83%D1%82%D0%B8%20%D0%94%D0%BE%D0%BC%D0%BE%D0%B9%20(2021)%20-%20%D0%A0%D1%83%D1%81%D1%81%D0%BA%D0%B8%D0%B9%20%D0%A2%D1%80%D0%B5%D0%B9%D0%BB%D0%B5%D1%80%20%D0%9A%D0%BE%D0%BD%D1%86%D0%B5%D0%BF%D1%82%20%D0%A4%D0%B0%D0%BD%D0%B0%D1%82%D1%81%D0%BA%D0%B8%D0%B9%20%20_%20%D0%A2%D0%BE%D0%BC%20%D0%A5%D0%BE%D0%BB%D0%BB%D0%B0%D0%BD%D0%B4.mp4?�6�   5>      5?      �� 5A      $
��Left=�6   
�������$	��100��6A   5C      5D      5E      5F      