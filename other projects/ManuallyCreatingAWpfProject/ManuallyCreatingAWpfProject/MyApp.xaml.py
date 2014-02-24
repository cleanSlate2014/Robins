import wpf
import clr

#Adding Refrence
clr.AddReference("PresentationFramework")
clr.AddReference("PresentationCore")
clr.AddReference("WindowsBase")

from System import *
from System.Windows import *
from System.Windows.Controls import *
from System.Windows.Data import *
from System.Windows.Documents import *
from System.Windows.Media import *
from System.Windows.Navigation import *
from System.Windows.Shapes import *





class App(Application):
    def __init__(self):
        wpf.LoadComponent(self, 'MyApp.xaml')


    def AppStartup(self,sender,args):

        Application().Run(MyWindow())

       
    
    


if __name__ == '__main__':
    App()
   