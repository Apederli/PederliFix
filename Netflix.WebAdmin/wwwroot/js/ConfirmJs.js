function confirmDelete(id,isDeleteClicked) {
    var deleteSpan = 'deleteSpan_' + id;
    var modalPopup = 'modalPopup_' + id;
    if (isDeleteClicked) {
        //$('#' + deleteSpan).hide();
        $('#' + modalPopup).show();
    } else {
        $('#' + deleteSpan).show();
        $('#' + modalPopup).hide();
    }
}