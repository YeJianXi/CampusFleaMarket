$(document).ready(function () {
    //添加按钮点击弹框
    $("#Create").click(function () {
        //alert("ajax请求修改部分视图")
        $("#modal-content").load("UserManager/PartialCreate", function (req, sta, xhr) {
            //alert(req);
        })

    })

    //编辑按钮点击跳弹框
    $(".Edit").click(function () {
        //alert("ajax请求修改部分视图")
        var primaryId = $(this).data("primaryid");
        //alert(primaryId)
        $("#modal-content").load("UserManager/PartialEdit", "id=" + primaryId, function (req, sta, xhr) {
            //var a = document.getElementById("modal-content");
            //a.innerText = req
        })

    })



    //删除按钮点击跳弹框
    $(".Delete").click(function () {
        //alert("ajax请求修改部分视图")
        var primaryId = $(this).data("primaryid");
        //alert(primaryId)
        $("#modal-content").load("UserManager/PartialDelete", "id=" + primaryId, function (req, sta, xhr) {
            //var a = document.getElementById("modal-content");
            //a.innerText = req
        })

    })


    //详细按钮点击跳弹框
    $(".Detail").click(function () {
        //alert("ajax请求修改部分视图")
        var primaryId = $(this).data("primaryid");
        //alert(primaryId)
        $("#modal-content").load("UserManager/PartialDetail", "id=" + primaryId, function (req, sta, xhr) {
            //var a = document.getElementById("modal-content");
            //a.innerText = req
        })

    })





    /******2.0为批量删除按钮添加点击事件*******/
    /****2.1 为全选按钮添加业务逻辑****/

    $("#checkAll").click(function () {
        var checkboxs = document.getElementsByName("select")
        for (var i = 0; i < checkboxs.length; i++) {
            checkboxs[i].checked = this.checked;
        }
    })

    //批量删除
    $("#AllDelte").click(function () {
        if (confirm("你确定要删除所选数据吗？")) {
            $("#AllDeleteForm").submit();
        }
    })

})