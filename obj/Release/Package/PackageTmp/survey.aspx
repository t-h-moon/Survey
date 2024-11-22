<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="survey.aspx.cs" Inherits="Survey.survey" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Survey Results</title>

    <link rel="stylesheet" href="SurveyStyle.css"/>
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" />
    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js"></script>

</head>
<body>
<form id="form1" runat="server">

    <div class='container'>
    <div class='main_content row justify-content-center'>
    <div class='col'><h2 class='text-center'>The Survey Result's Page</h2>
    <hr />
        <asp:Label ID="lblThanks" runat="server" Text="Label" ></asp:Label>
    <hr />

    <div class='card-header'>
        <p><strong>Your Student Information: </strong></p>  
        <asp:Label ID="lblDisplay" runat="server" Text="Label"></asp:Label>
        </div>
<br />
     <div class='card-header'>
         <p><strong>Your Course Answers: </strong></p>  
         <asp:Label ID="lblAnswers" runat="server"></asp:Label>
    </div>
<br />
      <div class='card-header'>
         <p><strong>Your Instructor Answers: </strong></p>  
         <asp:Label ID="lblAnswers2" runat="server"></asp:Label>
    </div>
<br />
      <div class='card-header'>
         <p><strong>Grades: </strong></p>  
         <asp:Label ID="lblCalculate" runat="server"></asp:Label>
    </div>
<br />
        <hr />
<br />
    </div>
        </div>
        </div>
    </form>
</body>
</html>
