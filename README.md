# wpf-mvvm-example
A demo project which demonstrates mvvm architecture.

This project was developed using Visual Studio 2012.

MVVM architecture.
Model-View-ViewModel pattern is a three tier architecture which is used for the seperation of UI controls from their logic.
 Each of the Model, View and ViewModel components are decoupled from each other.
 
 What is WPF?
 Windows Presentation Foundtion(WPF) is a graphical subsystem for rendering user interfaces in Windows-based applications.
 WPF uses XAML, which is an XML base language to define and link various interface elements.
 
 Model:- This is an implementation of application's domain model that includes a data modelalong with business and validation logic.
 
 ViewModel:- This is a layer inbetween view and model.  ViewModel provides data from the model in a form that the view can easily use.
 This also provides implementation of commands that a user of the application initiates. 
 For ViewModel to participate in two way data binding with the view, its properties must raise PropertyChanged event.
 This requirement is satisfied by implementing the INotifyPropertyChanged and raising PropertyChanged event when a property is changed.
 
 View :- view consists of the UI. In WPF it is the XAML file which defines the controls, we should add bindings in here for the architecture to work.

 When connecting View model to Views the main idea is to assign the ViewModel to the DataContext property of the View.
 Code-Behind:- Purists of MVVM prefer not to have any code-behind related to the ui and that's the best way to implement this architecture as well.
 
 About the Project:- In this project when a button is clicked the displayed message on a label is changed and also an Image is displayed.
 
 Links followed: -
 https://msdn.microsoft.com/en-us/library/hh848246.aspx 
 http://www.codeproject.com/Tips/813345/Basic-MVVM-and-ICommand-Usage-Example