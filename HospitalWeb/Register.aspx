<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="HospitalWeb.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title>E-Randevu</title>
    <meta charset="utf-8">
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no">
	
	<link href="https://fonts.googleapis.com/css?family=Lato:300,400,700&display=swap" rel="stylesheet">

	<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/font-awesome/4.7.0/css/font-awesome.min.css">
	
	<link rel="stylesheet" href="css/style.css">
    <style type="text/css">
        .auto-style1 {
            width: 120px;
            height: 42px;
            margin-top: 0px;
        }
    </style>
</head>
<body class="img js-fullheight"  style=" background-image: url('images/Screenshot_9.png');">
  
   <section class="ftco-section">
		<div class="container">
			
			<div class="row justify-content-center">
				<div class="col-md-6 col-lg-4">
					<div class="login-wrap py-5" style="background-color:firebrick">
		      	<div class="img d-flex align-items-center justify-content-center" style="background-image: url(images/Screenshot_2.jpg);"></div>
		      	<h3 class="text-center mb-0">E-Randevu</h3>
		      	<p class="text-center">Aşağıdaki bilgileri girerek Kayıt Olun</p>
						<form runat="server" action="#" class="login-form">
		      		<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			<input type="text" class="form-control" placeholder="T.C. Kimlik No" required>
		      		</div>
							<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			<input type="text" class="form-control" placeholder="Ad" required>
		      		</div>
							<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-user"></span></div>
		      			<input type="text" class="form-control" placeholder="Soyad" required>
		      		</div>
							<div class="form-group">
		      			<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-phone"></span></div>
		      			<input type="text" class="form-control" placeholder="Numara" required>
		      		</div>
							<div class="form-group">
		      			<div class="icon d-flex  align-items-center justify-content-center"><span class="fa fa-calendar-o"></span></div>
		      			<input type="text" class="form-control" placeholder="Doğum Tarihi" required>
		      		</div>
	            <div class="form-group">
	            	<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-lock"></span></div>
	              <input type="password" class="form-control" placeholder="Şifre" required>
	            </div>
							<div class="form-group">
	            	<div class="icon d-flex align-items-center justify-content-center"><span class="fa fa-lock"></span></div>
	              <input type="password" class="form-control" placeholder="Tekrar Şifre" required>
	            </div>

	            <div class="form-group d-md-flex">
       <div  class="w-50">
           <label style="height: 15px;" class="checkbox-wrap checkbox-primary">
               Erkek
									  <input   type="checkbox" checked="" />
               <span   class="checkmark"></span>

           </label>

           <label style="height: 10px" class="checkbox-wrap checkbox-primary">
               Kadın
								<input type="checkbox" checked="" />
               <span class="checkmark"></span>
           </label>

       </div>
								
	            </div>
						
				 <div class="form-group">
           <asp:Button ID="btn" runat="server"  OnClick="btn_Click" CssClass="btn btn-danger" Text="Kayıt Ol" style="background-color:#FFEBEE;font-weight:900; color:black; width : 298px; height: 48px "></asp:Button>
       </div>
	          </form>
	          <div class="w-100 text-center mt-4 text">
				   <p class="w-100 text-center">&mdash; Veya Kayıt Ol &mdash;</p>
						<div  align="center">
							<a  href="https://giris.turkiye.gov.tr/Giris/gir"> <img src="images/Screenshot_4.jpg" class="auto-style1" /></a>
						</div><br />
	          
				  
	          </div>
	        </div>
				</div>
			</div>
		</div>
	</section>

	<script src="js/jquery.min.js"></script>
  <script src="js/popper.js"></script>
  <script src="js/bootstrap.min.js"></script>
  <script src="js/main.js"></script>

</body>
</html>