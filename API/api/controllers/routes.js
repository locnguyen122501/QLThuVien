'use strict';
// let productsCtrl = require('./controllers/ProductsController');

const express = require('express');
const productsCtrl = require('./ProductsController');

const route = express.Router();


//get
route.get("/book", productsCtrl.get)
route.get("/theloai", productsCtrl.gettheloai)
route.get("/taikhoan", productsCtrl.gettaikhoan)
route.get("/docgia", productsCtrl.getdocgia)
route.get("/the", productsCtrl.getthe)
route.get("/nhaxuatban", productsCtrl.getnhaxuatban)
route.get("/phieumuon", productsCtrl.getphieumuon)
route.get("/phieutra", productsCtrl.getphieutra)
route.get("/quydinh", productsCtrl.getquydinh)
route.get("/thuthu", productsCtrl.getthuthu)
route.get("/book/GMBT", productsCtrl.getGMBT)
route.get("/book/KTKH", productsCtrl.getKTKH)
route.get("/book/TT", productsCtrl.getTT)
route.get("/book/VHNC", productsCtrl.getVHNC)
route.get("/book/VHVN", productsCtrl.getVHVN)
route.get("/book/WB", productsCtrl.getWB)
//getdetail
route.get("/book/:MaSach", productsCtrl.detailbook)
route.get("/docgia/:MaDocGia", productsCtrl.detaildocgia)
route.get("/nhaxuatban/:MaNXB", productsCtrl.detailnhaxuatban)
route.get("/phieumuon/:MaPhieuMuon", productsCtrl.detailphieumuon)
route.get("/phieutra/:MaPhieuTra", productsCtrl.detailphieutra)
route.get("/quydinh/:MaQD", productsCtrl.detailquydinh)
route.get("/thuthu/:MaTT", productsCtrl.detailthuthu)
route.get("/theloai/:MaTheLoai", productsCtrl.detailtheloai)
route.get("/the/:MaThe", productsCtrl.detailthe)
route.get("/taikhoan/:TK",productsCtrl.detailuser);
//route.get("/book/:MaTheLoai",productsCtrl.kttheloai);
// post
route.post("/book",productsCtrl.postbook)
route.post("/theloai",productsCtrl.posttheloai)
route.post("/taikhoan",productsCtrl.posttaikhoan)
route.post("/docgia",productsCtrl.postdocgia)
route.post("/the",productsCtrl.postthe)
route.post("/nhaxuatban",productsCtrl.postnhaxuatban)
route.post("/phieumuon",productsCtrl.postphieumuon)
route.post("/phieutra",productsCtrl.postphieutra)
route.post("/quydinh",productsCtrl.postquydinh)
route.post("/thuthu",productsCtrl.postthuthu)
//put
route.put("/book/:MaSach", productsCtrl.updatebook)
route.put("/theloai/:MaTheLoai", productsCtrl.updatetheloai)
route.put("/docgia/:MaDocGia", productsCtrl.updatedocgia)
route.put("/the/:MaThe", productsCtrl.updatethe)
route.put("/nhaxuatban/:MaNXB", productsCtrl.updatenhaxuatban)
route.put("/phieumuon/:MaPhieuMuon", productsCtrl.updatephieumuon)
route.put("/phieutra/:MaPhieuTra", productsCtrl.updatephieutra)
route.put("/quydinh/:MaQD", productsCtrl.updatequydinh)
route.put("/thuthu/:MaTT", productsCtrl.updatethuthu)
route.put("/taikhoan/:MaTK", productsCtrl.updatetaikhoan)

//delete
route.delete("/book/delete/:MaSach", productsCtrl.deletebook)
route.delete("/theloai/delete/:MaTheLoai", productsCtrl.deletetheloai)
route.delete("/docgia/delete/:MaDocGia", productsCtrl.deletedocgia)
route.delete("/the/delete/:MaThe", productsCtrl.deletethe)
route.delete("/nhaxuatban/delete/:MaNXB", productsCtrl.deletenhaxuatban)
route.delete("/phieumuon/delete/:MaPhieuMuon", productsCtrl.deletephieumuon)
route.delete("/phieutra/delete/:MaPhieuTra", productsCtrl.deletephieutra)
route.delete("/quydinh/delete/:MaQD", productsCtrl.deletequydinh)
route.delete("/taikhoan/delete/:MaTK", productsCtrl.deletetaikhoan)
route.delete("/thuthu/delete/:MaTT", productsCtrl.deletethuthu)






module.exports = route;
