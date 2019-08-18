function Default(URL) {
	$.ajax({
		url: URL,
		type: 'POST',
		cache: false,
		success: function (result) {
			window.location.reload();
		}
	});
}

function SelectPatient(URL, fromDate, toDate, actionname, controllername) {
	$.ajax({
		url: URL,
		type: 'GET',
		data: { PageNo: 1, PageSize: 10, fromDate: fromDate, toDate: toDate, actionname: actionname, controllername: controllername, search: $("#txtPatientSearch").val() },
		cache: false,
		success: function (result) {
			$('#divSelectPatientList').modal('show');
			$('#divSelectPatientList').html(result);
		}
	});
}

function DeleteRecord(value, tablename, primaryid) {
	$.ajax({
		url: '/Base/DeleteRecord',
		type: 'POST',
		data: { value: value, tablename: tablename, primaryid: primaryid },
		cache: false,
		success: function (result) {
			window.location.reload();
		}
	});
}

function DeleteRecordView(value, tablename, primaryid) {
	$.ajax({
		url: '/Base/DeleteRecordView',
		type: 'POST',
		data: { value: value, tablename: tablename, primaryid: primaryid },
		cache: false,
		success: function (result) {
			$("#divDeleteRecord").html(result);
			$("#deleterecord").modal('show');
		}
	});
}