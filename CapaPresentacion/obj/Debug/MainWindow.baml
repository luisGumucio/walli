   M S B A M L   `   `   `  ����K  GCapaPresentacion, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:CapaPresentacionCapaPresentacion  5   	   !    CapaPresentacion.MainWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0localclr-namespace:CapaPresentacion     5   	     � Title$  
MainWindow��5   	   $	��450��6   $	��800��6)    � WindowStyle$
 None=�66    � WindowStartupLocation$ CenterScreen=�6I    � 
ResizeMode$ NoResize=�6n   .��5	      � ���	#FFF2F2F2$��0,0,-60,-22q�6"   .+�5
   
   �� -   5        $��image1��5
      $��40��6   $!��imagenes/imgFondoTitulo.png��6*   $
��Fill=�6P   $	��Top=�6_   �� 5   
   -   5        $��label1��5   �   $��Walli Chicken��6   $��Arial)�6(   $��18(�6;   $
��Bold"�6I   $��40��6[   $
��Left=�6g   $��30,0,0,0q�6�   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $��
rectangle1��5   5   $	��401��6   $��
30,50,30,0q�6!   ���	#FFD9D9D9$	��Top=�6Z    �� RadiusX$ 8��6r    �� RadiusY$ 8��6~   
�������6�   �� 5   
   -   5        $��image2��5   P   $	��170��6   $��Center=�6   $��305,40,355,0q�6:   $
��Fill=�6^   $	��Top=�6m   $	��200��6�   $��Iconos/icoPersona.png��6�   �� 5   
   -   5        $��label3��5   �   $��Login:��6   $��Arial)�6!   $��18(�64   $��Normal"�6B   $��40��6V   $
��Left=�6b   $��220,210,0,0q�6}   $	��Top=�6�   $��Center=�6�   �� 5   
   -   5        $��label4��5   �   $��	Password:��6   $��Arial)�6$   $��18(�67   $��Normal"�6E   $��40��6Y   $
��Left=�6e   $��220,256,0,0q�6�   $	��Top=�6�   $��Center=�6�   $
��Auto��6�   �� 5   
   -   5        $��txtLoginUser��5   N   $��25��6   $
��Left=�6   $��319,215,0,0q�69   $	��Top=�6b   $	��250��6z   $��0q�6�   $��Center=�6�   $��5,0,0,0q�6�   $��14(�6�   $�� ��6�    �� 	MaxLength$ 15��6�   .��6�   ��5      �� 5       �� ImageSource$+ %/imagenes/imgFondoTextBoxIngresar.png��6   .��5   "   5      G� 5   
   -   5        $��txtPasswordLogin��5   R   $��24��6   $
��Left=�6"   $��319,256,0,0q�6=   $	��Top=�6j   $	��250��6�   $��0q�6�   $��Center=�6�   $��5,0,0,0q�6�   $��14(�6�    G� Password$  ��6�   	 G� 	MaxLength$	 30��6�   ��5      �� 5      $+ %/imagenes/imgFondoTextBoxIngresar.png��6   5      �� 5   
   -	   5        $��btnIngresar��5   `   $��Ingresar��6   $��35��6$   $
��Left=�60   $��417,342,0,0q�6K   $	��Top=�6s   $	��160��6�   $��1q�6�   $��Arial)�6�   $��16(�6�   
���������6�   Z� ��5      �� 5      $! /imagenes/imgFondoBoton.png��6   5      �� 5   
   -
   5        $��btnSalir��5   �   $��1q�6(   $��Salir��6<   $��Arial)�6L   $��16(�6_   
�������$��35��6�   $
��Left=�6�   $��220,342,0,0q�6�   $	��Top=�6�   $	��160��6�   ��6   Z� ��5       �� 5!      $! /imagenes/imgFondoBoton.png��6   5#      �� 5$   
   -   5        $��imgOk��5$   L   $��38��6   $
��Left=�6   $��661,313,0,0q�67   $
��Fill=�6Y   $	��Top=�6h   $��38��6�   $��Iconos/icoBien.png��6�   $y�Hidden=�6�   �� 5%   
   -   5        $��imgError��5%   L   $��38��6   $
��Left=�6   $��661,313,0,0q�67   $
��Fill=�6\   $	��Top=�6k   $��38��6�   $��Iconos/icoMal.png��6�   $y�Hidden=�6�   �� 5&   
   -   5        $��
lblMensaje��5&   �   $0��*Ingrese sus datos para ingresar al sistema��6   $
��Auto��6E   $��Center=�6S   $��265,309,283,0q�6p   $	��Top=�6�   $��Arial)�6�   $��16(�6�   
��� � �$	��312��6�   5'      5(      