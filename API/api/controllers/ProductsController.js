'use strict'

const util = require('util')
const mysql = require('mysql')
const db = require('./db')

const productsCtrl = {
    get: (req, res) => {
        let sql = 'SELECT * FROM sach'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    gettheloai: (req, res) => {
        let sql = 'SELECT * FROM theloai'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    gettaikhoan: (req, res) => {
        let sql = 'SELECT * FROM taikhoan'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getdocgia: (req, res) => {
        let sql = 'SELECT * FROM docgia'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getthe: (req, res) => {
        let sql = 'SELECT * FROM the'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getthuthu: (req, res) => {
        let sql = 'SELECT * FROM thuthu'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getquydinh: (req, res) => {
        let sql = 'SELECT * FROM quydinh'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getphieutra: (req, res) => {
        let sql = 'SELECT * FROM phieutra'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getphieumuon: (req, res) => {
        let sql = 'SELECT * FROM phieumuon'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getnhaxuatban: (req, res) => {
        let sql = 'SELECT * FROM nhaxuatban'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getGMBT: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "GMBT"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getKTKH: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "KTKH"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getTT: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "TT"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getVHNC: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "VHNC"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getVHVN: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "VHVN"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },
    getWB: (req, res) => {
        let sql = 'SELECT * FROM sach WHERE MaTheLoai = "WB"'
        db.query(sql, (err, response) => {
            if (err) console.log(err)
            res.send(response)
        })
    },

    //post
    postbook: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO sach SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postdocgia: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO docgia SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postnhaxuatban: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO nhaxuatban SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postphieumuon: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO phieumuon SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postphieutra: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO phieutra SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postquydinh: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO quydinh SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    posttaikhoan: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO taikhoan SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postthe: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO the SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    posttheloai: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO theloai SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
    postthuthu: (req, res) => {
        let data = req.body;
        let sql = 'INSERT INTO thuthu SET ?'
        db.query(sql, [data], (err, response) => {
            if (err) throw err
            res.send({ message: 'Insert success!' })
        })
    },
//kt
   /* kttheloai: (req, res) => {
        let sql = 'SELECT * FROM sach  WHERE MaTheLoai = ?'
        db.query(sql, [req.params.MaTheLoai], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },*/
    detailuser: (req, res) => {
        let sql = 'SELECT * FROM taikhoan WHERE MaTK = ?'
        db.query(sql, [req.params.TK], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
      detailbook: (req, res) => {
        let sql = 'SELECT * FROM sach  WHERE MaSach = ?'
        db.query(sql, [req.params.MaSach], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detaildocgia: (req, res) => {
        let sql = 'SELECT * FROM docgia  WHERE MaDocGia = ?'
        db.query(sql, [req.params.MaDocGia], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailnhaxuatban: (req, res) => {
        let sql = 'SELECT * FROM nhaxuatban  WHERE MaNXB = ?'
        db.query(sql, [req.params.MaNXB], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailphieumuon: (req, res) => {
        let sql = 'SELECT * FROM phieumuon  WHERE MaPhieuMuon = ?'
        db.query(sql, [req.params.MaPhieuMuon], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailphieutra: (req, res) => {
        let sql = 'SELECT * FROM phieutra  WHERE MaPhieuTra = ?'
        db.query(sql, [req.params.MaPhieuTra], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailquydinh: (req, res) => {
        let sql = 'SELECT * FROM quydinh  WHERE MaQD = ?'
        db.query(sql, [req.params.MaQD], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailthe: (req, res) => {
        let sql = 'SELECT * FROM the  WHERE MaThe = ?'
        db.query(sql, [req.params.MaThe], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailtheloai: (req, res) => {
        let sql = 'SELECT * FROM theloai  WHERE MaTheLoai = ?'
        db.query(sql, [req.params.MaTheLoai], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
    detailthuthu: (req, res) => {
        let sql = 'SELECT * FROM thuthu  WHERE MaTT = ?'
        db.query(sql, [req.params.MaTT], (err, response) => {
            if (err) throw err
            res.json(response[0])
        })
    },
//put
    updatebook: (req, res) => {
        let data = req.body;
        let MaSach = req.params.MaSach;
	console.log(req.param);
        let sql = 'UPDATE sach SET ? WHERE MaSach = ?'
        db.query(sql, [data, MaSach], (err, response) => {
            if (err) throw err
            res.json({message: 'Update success!'})
            })
        },
     updatetheloai: (req, res) => {
        let data = req.body;
        let MaTheLoai = req.params.MaTheLoai;
        let sql = 'UPDATE theloai SET ? WHERE MaTheLoai = ?'
        db.query(sql, [data, MaTheLoai], (err, response) => {
            if (err) throw err
            res.json({message: 'Update success!'})
            })
        },
        updatedocgia: (req, res) => {
            let data = req.body;
            let MaDocGia = req.params.MaDocGia;
            let sql = 'UPDATE docgia SET ? WHERE MaDocGia = ?'
            db.query(sql, [data, MaDocGia], (err, response) => {
                if (err) throw err
                res.json({message: 'Update success!'})
                })
            },
    updatenhaxuatban: (req, res) => {
        let data = req.body;
        let MaNXB = req.params.MaNXB;
        let sql = 'UPDATE nhaxuatban SET ? WHERE MaNXB = ?'
            db.query(sql, [data, MaNXB], (err, response) => {
                if (err) throw err
                 res.json({message: 'Update success!'})
                })
        },
    updatephieumuon: (req, res) => {
        let data = req.body;
        let MaPhieuMuon = req.params.MaPhieuMuon;
        let sql = 'UPDATE phieumuon SET ? WHERE MaPhieuMuon = ?'
            db.query(sql, [data, MaPhieuMuon], (err, response) => {
                if (err) throw err
                    res.json({message: 'Update success!'})
            })
        },
    updatephieutra: (req, res) => {
            let data = req.body;
            let MaPhieuTra = req.params.MaPhieuTra;
            let sql = 'UPDATE phieutra SET ? WHERE MaPhieuMuon = ?'
                db.query(sql, [data, MaPhieuTra], (err, response) => {
                    if (err) throw err
                        res.json({message: 'Update success!'})
                })
            },
    updatequydinh: (req, res) => {
            let data = req.body;
            let MaQD = req.params.MaQD;
            let sql = 'UPDATE quydinh SET ? WHERE MaQD = ?'
                 db.query(sql, [data, MaQD], (err, response) => {
                        if (err) throw err
                            res.json({message: 'Update success!'})
                    })
                },
     updatetaikhoan: (req, res) => {
            let data = req.body;
            let MaTK = req.params.MaTK;
            let sql = 'UPDATE taikhoan SET ? WHERE MaTK = ?'
                db.query(sql, [data, MaTK], (err, response) => {
                        if (err) throw err
                            res.json({message: 'Update success!'})
                        })
                    },
     updatethuthu: (req, res) => {
            let data = req.body;
            let MaTT = req.params.MaTT;
            let sql = 'UPDATE thuthu SET ? WHERE MaTT = ?'
                db.query(sql, [data, MaTT], (err, response) => {
                        if (err) throw err
                             res.json({message: 'Update success!'})
                            })
            },
     updatethe: (req, res) => {
            let data = req.body;
            let MaThe = req.params.MaThe;
            let sql = 'UPDATE thuthu SET ? WHERE MaThe = ?'
                 db.query(sql, [data, MaThe], (err, response) => {
                    if (err) throw err
                         res.json({message: 'Update success!'})
                })
         },

//delete
deletebook: (req, res) => {
    let sql = 'DELETE FROM sach WHERE MaSach = ?'
    db.query(sql, [req.params.MaSach], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletedocgia: (req, res) => {
    let sql = 'DELETE FROM docgia WHERE MaDocGia = ?'
    db.query(sql, [req.params.MaDocGia], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletenhaxuatban: (req, res) => {
    let sql = 'DELETE FROM nhaxuatban WHERE MaNXB = ?'
    db.query(sql, [req.params.MaNXB], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletephieumuon: (req, res) => {
    let sql = 'DELETE FROM phieumuon WHERE MaPhieuMuon = ?'
    db.query(sql, [req.params.MaPhieuMuon], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletephieutra: (req, res) => {
    let sql = 'DELETE FROM phieutra WHERE MaPhieuTra = ?'
    db.query(sql, [req.params.MaPhieuTra], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletequydinh: (req, res) => {
    let sql = 'DELETE FROM quydinh WHERE MaQD = ?'
    db.query(sql, [req.params.MaQD], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletetaikhoan: (req, res) => {
    let sql = 'DELETE FROM taikhoan WHERE MaTK = ?'
    db.query(sql, [req.params.MaTK], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletethe: (req, res) => {
    let sql = 'DELETE FROM the WHERE MaThe = ?'
    db.query(sql, [req.params.MaThe], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletetheloai: (req, res) => {
    let sql = 'DELETE FROM theloai WHERE MaTheLoai = ?'
    db.query(sql, [req.params.MaTheLoai], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
},
deletethuthu: (req, res) => {
    let sql = 'DELETE FROM thuthu WHERE MaTT = ?'
    db.query(sql, [req.params.MaTT], (err, response) => {
        if (err) throw err
        res.send({ message: 'Delete success!' })
    })
}
    }

module.exports = productsCtrl;