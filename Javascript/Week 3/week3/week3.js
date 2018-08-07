//JavaScript Document

window.addEventListener("load", init)

function init()
{
   document.getElementById("sub").addEventListener("click", myfunction);
        
    var header1 = document.getElementById("head0");
    var header2 = document.getElementById("head1");
    var header3 = document.getElementById("head2");
    var header4 = document.getElementById("head3");
    var header5 = document.getElementById("head4");
    
    var fName = document.getElementById("first");
    var lName = document.getElementById("last");
    var email = document.getElementById("email");
    var emailConfirm = document.getElementById("email-confirm");
    var phone = document.getElementById("phone");
    
    function myfunction()
    {   
        if (fName.value === "")
        {    
           header1.style.color="red";
           
           var fName_error = document.getElementById("fn-error").innerHTML ="*";
        }
        else var fNameT ="true";
        
        if (lName.value === "")
        {
            header2.style.color="red";
            
            var lName_error = document.getElementById("ln-error").innerHTML ="*";
        }
        else var lNameT ="true";
        
        if (email.value === "")
        {
            header3.style.color="red";
            
            var email_error = document.getElementById("email-error").innerHTML ="*";
        }
        
        if (emailConfirm.value === "")
        {
            header4.style.color="red";
            
             var emailConfirm_error = document.getElementById("email-confirm-error").innerHTML ="*";
        }
        
        if (phone.value === "")
        {
            header5.style.color="red";
            
            var phone_error = document.getElementById("phone-error").innerHTML ="*";
        }
        else var phoneT ="true";
        
        if (email.value === emailConfirm.value && fNameT === "true")
        {
            if (lNameT === "true" && phoneT === "true")
            {
            
                document.getElementById("confirmation").style.display ="block";
            
                document.getElementById("p1").innerHTML=fName.value;
                document.getElementById("p2").innerHTML=lName.value;
                document.getElementById("p3").innerHTML=email.value;
                document.getElementById("p4").innerHTML=phone.value;
            }
        } 
        
        
    } // function end myfunction
    
} // function end init