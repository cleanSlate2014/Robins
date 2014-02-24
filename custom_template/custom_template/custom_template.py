import wpf


from System.Windows import *



class MyWindow(Window):
    def __init__(self):
        wpf.LoadComponent(self, 'custom_template.xaml')

        
   

         
if __name__ == '__main__':
    Application().Run(MyWindow())  
