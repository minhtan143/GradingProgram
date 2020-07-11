use GradingProgram
----Question------
Set IDENTITY_INSERT dbo.Question on
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (1,'TinhTong',N'Tính tổng 2 số nguyên nhập từ màn hình','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (2,'TinhHieu',N'Tính hiệu 2 số nguyên nhập từ màn hình','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (3,'TinhTich',N'Tính tích 2 số nguyên nhập từ màn hình','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (4,'TinhThuong',N'Tính thương 2 số nguyên nhập từ màn hình','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (5,'TimTriTuyetDoi',N'Tìm trị tuyệt đối của một số nhập từ màn hình','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (6,'SoChinhPhuong',N'Kiểm tra 1 số có phải là số chính phương hay không?','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (7,'TimMax',N'Tìm số lớn nhất của dãy số 1,2,3,4,5,6','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (8,'TimMin',N'Tìm số nhỏ nhất của dãy số 1,2,3,4,5,6','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (9,'SapXepTangDan',N'Sắp xếp dãy số sau theo thứ tự tăng dần 9,5,7,6,11','12-17-1999',1)
Insert into dbo.Question (ID,Name,Detail,CreateDate,Status) values (10,'SapXepGiamDan',N'Sắp xếp dãy số sau theo thư tự giảm dần 11,10,15,16,9','12-17-1999',1)
Set IDENTITY_INSERT dbo.Question off

----Candidate------
Set IDENTITY_INSERT dbo.Candidate on
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(1,17110567,N'Nguyễn Văn A','0988545856','A@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(2,17110568,N'Nguyễn Văn B','0988545123','B@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(3,17110569,N'Nguyễn Văn C','0988545456','B@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(4,17110560,N'Nguyễn Văn D','0988545756','C@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(5,17110561,N'Nguyễn Văn E','0988645856','D@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(6,17110562,N'Nguyễn Văn F','0988545856','E@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(7,17110563,N'Nguyễn Văn H','0978545856','F@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(8,17110564,N'Nguyễn Văn I','0981545856','H@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(9,17110565,N'Nguyễn Văn K','0988555856','I@gmail.com',1)
Insert into dbo.Candidate(ID,Code,Name,Phone,Email,Status) values(10,17110566,N'Nguyễn Văn M','0986545856','K@gmail.com',1)
Set IDENTITY_INSERT dbo.Candidate off

-----Exam--------
Set IDENTITY_INSERT dbo.Exam on
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(1,'HK1-2010','..\..\..\HK1-2010','12-25-2010',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(2,'HK2-2010','C:\Exam\HK2-2010','12-25-2010',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(3,'HK1-2011','C:\Exam\HK1-2011','12-25-2011',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(4,'HK2-2011','C:\Exam\HK2-2011','12-25-2011',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(5,'HK1-2012','C:\Exam\HK1-2012','12-25-2012',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(6,'HK2-2012','C:\Exam\HK2-2012','12-25-2012',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(7,'HK1-2013','C:\Exam\HK1-2013','12-25-2013',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(8,'HK2-2013','C:\Exam\HK2-2013','12-25-2013',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(9,'HK1-2014','C:\Exam\HK1-2014','12-25-2014',1)
Insert into dbo.Exam(ID,Name,Folder,CreateDate,Status) values(10,'HK2-2014','C:\Exam\HK2-2014','12-25-2014',1)
Set IDENTITY_INSERT dbo.Exam off

-----CandidateDetail------
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(1,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(2,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(3,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(4,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(5,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(6,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(7,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(8,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(9,1)
Insert into dbo.CandidateDetail(CandidateID,ExamID) values(10,1)

------ExamDetail------
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (1,1,'Bai1');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (1,2,'Bai2');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (1,3,'Bai3');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (2,4,'Bai1');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (2,5,'Bai2');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (2,6,'Bai3');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (3,1,'Bai1');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (3,2,'Bai2');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (3,3,'Bai3');
Insert into dbo.ExamDetail(ExamID,QuestionID,FileName) values (3,4,'Bai4');

----TestCase-----
Set IDENTITY_INSERT dbo.TestCase on
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(1,'Test0','5 6','11',5,1100,10,1)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(2,'Test1','4 5','9',5,1100,10,1)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(3,'Test2','7 6','13',5,1100,10,1)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(4,'Test0','5 6','-1',5,1100,10,2)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(5,'Test1','7 6','1',5,1100,10,2)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(6,'Test2','8 6','2',5,1100,10,2)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(7,'Test0','5 6','30',5,1100,10,3)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(8,'Test1','7 6','42',5,1100,10,3)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(9,'Test2','8 6','48',5,1100,10,3)
Insert into dbo.TestCase(ID,Name,Input,Output,TimeLimit,MemoryLimit,Mark,QuestionID) values(10,'Test3','5 2','10',5,1100,10,3)
Set IDENTITY_INSERT dbo.TestCase on

--------Result---------
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,1,'11',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,2,'9',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,3,'13',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,4,'-1',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,5,'1',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,6,'2',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,7,'30',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,8,'42',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,9,'48',4,1000,10,'Correct')
Insert into dbo.Result (CandidateID,ExamID,TestCaseID,Output,RunTime,UsedMemory,Mark,Notification) values (4,1,10,'10',4,1000,10,'Correct')

