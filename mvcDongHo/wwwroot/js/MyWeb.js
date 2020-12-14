 //Hàm xóa thương hiệu
 //viết jquery, do xài cái model để xác nhận có muốn xóa hay không thì mình không lấy mã trực tiếp như cái sửa được nên phải viết thêm cái này  
$('button#xemchitietban').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonBan/HoaDonBan",
        data:{IDHoaDon:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                        +'<td>'+item.idSanPham+'</td>'
                        +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
$('button#xemchitietnhap').click(function ()
{
    var id = $(this).data("id");
    console.log(id);
    $.ajax({
        type:"GET",
        url:"/Admin/QuanLiHoaDonNhap/HoaDonNhap",
        data:{IDHoaDonNhap:id},
        success:function(response){
            console.log(response)
            $('tbody#content').empty();
            response.forEach(function(item) {
                var obj='<tr>'
                            +'<td>'+item.idSanPham+'</td>'
                            +'<td>'+item.soLuong+'</td>'
                        +'</tr>';
                $('tbody#content').append(obj);
            });
            
        }
    });   
});
    
