$(function(){



	var loadCategories = function(){
		//var credential = btoa('admin:123');
		$.ajax({
			type:'GET',
			url: 'http://localhost:1844/api/Customers/',
			dataType: 'Json',


			//  headers: {
   // //              Authorization: 'Basic ' + credential
   // //          }

			complete: function(xmlhttp){
				if(xmlhttp.status == 200)
				{
					var catList = xmlhttp.responseJSON;
					var outputStr = '';
					for(var i = 0; i < catList.length; i++)
					{
						 outputStr +='<tr><td>' + catList[i].Name +'</td><td>' + catList[i].Name + '</td><td>' + catList[i].Address + '</td><td>'+ catList[i].Phone + '</td><td>' + catList[i].Email + '</td><td>' + catList[i].Username + '</td></tr>';

					}
					$('#list').html(outputStr);

				}
				else
				{
					$('#msg').html(xmlhttp.status + ": " + xmlhttp.statusText);
				}
			}
		});
	}

	loadCategories();


	$('#btnLoad').click(loadCategories);

	$('#btnSave').click(function(){
		$.ajax({
			url: 'http://localhost:1844/api/Customers/',
			method: 'POST',
			header: 'Content-Type: application/json',
			data: {
				Name: $('#customername').val(),
				Address: $('#customeraddress').val(),
				Phone: $('#customerphone').val(),
				Email: $('#customeremail').val(),
				Username: $('#customerusername').val(),
				Password: $('#customerpassword').val()
			},
			complete: function(xmlhttp){
				if(xmlhttp.status == 201)
				{
					$('#msg').html("Successfully added");
					loadCategories();
				}
				else
				{
					$('#msg').html(xmlhttp.status + ": " + xmlhttp.statusText);
				}
			}
		});
	});
	$('#btndel').click(function(){

		

		var id= $('#del').val();
		alert(id);
		
		$.ajax({
			url: '/api/Customers/'+ id,
			method: 'DELETE',
			//header: 'Content-Type: application/json',
			cache:false,
			
			complete: function(xmlhttp){
				if(xmlhttp.status == 204)
				{
					$('#msg').html("Successfully Deleted");
					loadCategories();
					
				}
				else
				{
					$('#msg').html(xmlhttp.status + ": " + xmlhttp.statusText);
					loadCategories();
				}
			}
		});

	});


 	// $('#btndel').click(function(){
  //       var del_id= $(this).attr('Customer_Id');
  //       var $ele = $(this).parent().parent();
  //       $.ajax({
  //           type:'POST',
  //           url:'/api/Customers/',
  //           data:{'del_id':del_id},
  //           success: function(data){
  //                if(data=="YES"){
  //                   $ele.fadeOut().remove();
  //                   loadCategories();
  //                }else{
  //                       alert("can't delete the row")
  //                       loadCategories();
  //                }
  //            }

  //           });
  //       });




});










