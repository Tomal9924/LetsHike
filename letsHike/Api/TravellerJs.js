$(function(){



	var loadCategories = function(){
		//var credential = btoa('admin:123');
		$.ajax({
			type:'GET',
			url: 'http://localhost:1844/api/Travellers/',
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
						 outputStr +='<tr><td>' + catList[i].Name + '</td><td>' + catList[i].Phone + '</td><td>'+ catList[i].Email  + '</td><td>' + catList[i].Username + '</td></tr>';
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
			url: 'http://localhost:1844/api/Travellers/',
			method: 'POST',
			header: 'Content-Type: application/json',
			data: {
				Name: $('#tname').val(),
				
				Phone: $('#tphone').val(),
				Email: $('#temail').val(),
				Username: $('#tusername').val(),
				Password: $('#tpassword').val()
			},
			complete: function(xmlhttp){
				if(xmlhttp.status == 201)
				{
					$('#msg').html("Successfully added Your Information Guide !");
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
