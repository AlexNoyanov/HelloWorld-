
   var elems=document.getElementsByClassName('t1');
   var f1=document.getElementById("1");
   var f2=document.getElementById("2");
   var f3=document.getElementById("3");
   var f4=document.getElementById("4");
   var pointer=0;
   var imag=document.createElement('img');
   imag.src="icon1.png";
   imag.id="img";
   window.onload=function(){
   	elems[pointer].appendChild(imag);
   }

   f1.onclick=function(){
   	if (!(pointer==3)){
   		elems[pointer].removeChild(imag);
   		pointer=3;
   		elems[pointer].appendChild(imag);
   	}
   }
 
   f2.onclick=function(){
   	if (!(pointer==2)){
   		elems[pointer].removeChild(imag);
   		pointer=2;
   		elems[pointer].appendChild(imag);
   	}
   }

   f3.onclick=function(){
   	if (!(pointer==0)){
   		elems[pointer].removeChild(imag);
   		pointer=0;
   		elems[pointer].appendChild(imag);
   	}
   }

   f4.onclick=function(){
   	if (!(pointer==1)){
   		elems[pointer].removeChild(imag);
   		pointer=1;
   		elems[pointer].appendChild(imag);
   	}
   }
