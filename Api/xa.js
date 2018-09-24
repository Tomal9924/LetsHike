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
						 outputStr +='<tr><td>' + catList[i].Name + '</td><td>' + catList[i].Address + '</td><td>'+ catList[i].Phone + '</td><td>' + catList[i].Email + '</td><td>' + catList[i].Username + '</td></tr>';
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
});
