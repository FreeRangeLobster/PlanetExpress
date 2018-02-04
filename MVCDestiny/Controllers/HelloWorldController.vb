Imports System.Web.Mvc


Namespace Controllers
    Public Class HelloWorldController
        Inherits Controller

        ' GET: /HelloWorld
        'Function Index() As String
        '    'Return "This is my <b>default</b> action..."
        'End Function
        Function Index() As ActionResult
            Return View()
        End Function

        'GET: /HelloWorld/Welcome/
        Function Welcome(name As String, Optional numTimes As Integer = 1) As ActionResult
            'Return "This is the Welcome action method..."
            'Return HttpUtility.HtmlEncode("Hello" & name & "Numtime is: " & numTimes)
            'Return HttpUtility.HtmlEncode("Hello " & name & ", ID: " & id)

            ViewBag.Message = "Hello " & name
            ViewBag.Numtimes = numTimes
            Return View()


        End Function

    End Class
End Namespace




'Using System.Web;
'Using System.Web.Mvc; 

'Namespace MvcMovie.Controllers
'{ 
'    Public Class HelloWorldController :  Controller 
'    { 
'        // 
'        // GET: /HelloWorld/ 

'        Public String Index() 
'        { 
'            Return "This is my <b>default</b> action..."; 
'        } 

'        // 
'        // GET: /HelloWorld/Welcome/ 

'        Public String Welcome() 
'        { 
'            Return "This is the Welcome action method..."; 
'        } 
'    } 
'}