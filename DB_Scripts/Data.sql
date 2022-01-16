 exec  Insert_User	'mohamed','123456789','mohamed','hussein','cairo','1998-10-19','s'
 exec  Insert_User  'hussein','123456789','mohamed','hussein','alex','2002-5-19','s'
 exec  Insert_User  'ahmed','123456789','ahmed','sayed','cairo','2000-10-19','s'
 exec  Insert_User  'sayed','123456789','ahmed','sayed','cairo','2005-10-19','s'
 exec  Insert_User  'ramdan','123456789','ahmed','ramdan','cairo','1995-10-19','i'
 exec  Insert_User  'fathy','123456789','mustafa','fathy','cairo','1990-10-19','i'
 exec  Insert_User  'mustafa','123456789','mustafa','fathy','cairo','2006-10-19','i'
 exec  Insert_User  'ali','123456789','ali','ahmed','cairo','1980-10-19','i'
 exec  Insert_User  'samir','123456789','ahmed','samir','alex','1998-10-19','i'
 exec  Insert_User  'tohamy','123456789','ahmed','tohamy','alex','1998-10-19','s'
 exec  Insert_User  'saleh','123456789','ahmed','saleh','alex','1998-10-19','s'


exec Select_User_All
exec Select_Student_All
exec Select_Instructor_All

exec Delete_User 2


/* COURSE */
exec Insert_Course 'OOP', 30
exec Insert_Course 'DB', 30
exec Insert_Course 'Intro to Programming', 30

exec Select_Course_All


/* Question*/
BEGIN
	declare @C_ID int
	declare @Q_ID int
	/* OOP */
	select @C_ID = CID  from Course where Course.Cname = 'OOP'
	exec  Insert_Question  'Which is not a feature of OOP in general definitions ?', '1', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'Efficient Code'
		exec  Insert_Choices   @Q_ID, 'B', 'Code reusability'
		exec  Insert_Choices   @Q_ID, 'C', 'Modularity'
		exec  Insert_Choices   @Q_ID, 'D', 'Duplicate/Redundant data'
	exec  Insert_Question  'Who invented OOP ?', '1', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'Andrea Ferro'
		exec  Insert_Choices   @Q_ID, 'B', 'Adele Goldberg'
		exec  Insert_Choices   @Q_ID, 'C', 'Alan Kay'
		exec  Insert_Choices   @Q_ID, 'D', 'Dennis Ritchie'
	exec  Insert_Question  'Which was the first purely object oriented programming language developed?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'Kotlin'
		exec  Insert_Choices   @Q_ID, 'B', 'SmartTalk'
		exec  Insert_Choices   @Q_ID, 'C', 'Java'
		exec  Insert_Choices   @Q_ID, 'D', 'C++'
	exec  Insert_Question  'When OOP concept did first came into picture ?', '1', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', '1980’s'
		exec  Insert_Choices   @Q_ID, 'B', '1995'
		exec  Insert_Choices   @Q_ID, 'C', '1970’s'
		exec  Insert_Choices   @Q_ID, 'D', '1993'
	exec  Insert_Question  'Which feature of OOP indicates code reusability ?', '1', 'D', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'Abstraction'
		exec  Insert_Choices   @Q_ID, 'B', 'Polymorphism'
		exec  Insert_Choices   @Q_ID, 'C', 'Encapsulation'
		exec  Insert_Choices   @Q_ID, 'D', 'Inheritance'
	exec  Insert_Question  'Which header file is required in C++ to use OOP ?', '1', 'A', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'OOP can be used without using any header file'
		exec  Insert_Choices   @Q_ID, 'B', 'stdlib.h'
		exec  Insert_Choices   @Q_ID, 'C', 'iostream.h'
		exec  Insert_Choices   @Q_ID, 'D', 'stdio.h'
	exec  Insert_Question  'Why Java is Partially OOP language ?', '1', 'B', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'It allows code to be written outside classes'
		exec  Insert_Choices   @Q_ID, 'B', 'It supports usual declaration of primitive data types'
		exec  Insert_Choices   @Q_ID, 'C', 'It does not support pointers'
		exec  Insert_Choices   @Q_ID, 'D', 'It doesn’t support all types of inheritance'
	exec  Insert_Question  'Which among the following doesn’t come under OOP concept ?', '1', 'C', @C_ID
		set @Q_ID = IDENT_CURRENT('dbo.Question')
		exec  Insert_Choices   @Q_ID, 'A', 'Data hiding'
		exec  Insert_Choices   @Q_ID, 'B', 'Message passing'
		exec  Insert_Choices   @Q_ID, 'C', 'Platform independent'
		exec  Insert_Choices   @Q_ID, 'D', 'Data binding'
	exec  Insert_Question  'Trees are hierarchical data structures ?', '2', 'A', @C_ID
	exec  Insert_Question  'A tree node can have multiple parents ?', '2', 'B', @C_ID
	exec  Insert_Question  'A leaf node can have up to 2 children ?', '2', 'B', @C_ID
	exec  Insert_Question  'A binary tree node can have up to 2 children ?', '2', 'A', @C_ID
	exec  Insert_Question  'A binary tree is balanced if most interior nodes have 2 children ?', '2', 'A', @C_ID
	exec  Insert_Question  'A tree traversal visits every node in the tree ?', '2', 'A', @C_ID
	exec  Insert_Question  'The value of  a node is always greater than the values of its children ?', '2', 'B', @C_ID


	/* DB */
	select @C_ID = CID  from Course where Course.Cname = 'DB'
	exec  Insert_Question  'Which of the following is generally used for performing tasks like creating the structure of the relations, deleting relation ?', '1', 'D', @C_ID
	exec  Insert_Question  'Which of the following provides the ability to query information from the database and insert tuples into, delete tuples from, and modify tuples in the database ?', '1', 'A', @C_ID
	exec  Insert_Question  'Which one of the following given statements possibly contains the error ?', '1', 'D', @C_ID
	exec  Insert_Question  'What do you mean by one to many relationships ?', '1', 'B', @C_ID
	exec  Insert_Question  'A Database Management System is a type of _________software.', '1', 'A', @C_ID
	exec  Insert_Question  'The term "FAT" is stands for_____', '1', 'B', @C_ID
	exec  Insert_Question  'The term "NTFS" refers to which one of the following ?', '1', 'A', @C_ID
	exec  Insert_Question  'The term "NTFS" refers to which one of the following ?', '1', 'A', @C_ID
	exec  Insert_Question  'The relational database model was created by E.F. Codd.', '2', 'A', @C_ID
	exec  Insert_Question  'A database is called "self-describing" because it contains a description of itself.', '2', 'A', @C_ID
	exec  Insert_Question  'In a database, data is stored in spreadsheets which have rows and columns.', '2', 'B', @C_ID
	exec  Insert_Question  'A database has data and relationships.', '2', 'A', @C_ID
	exec  Insert_Question  'One of the reasons why OODBMSs have not been widely used for business information systems is that OOP is obsolete.', '2', 'B', @C_ID
	exec  Insert_Question  'Applications are programs that interact directly with the database.', '2', 'B', @C_ID
	exec  Insert_Question  'The purpose of a database is to help people stop using spreadsheets.', '2', 'B', @C_ID

END

exec Select_Question_All
exec Select_Choices_All





/* DELETE ALL PROCEDURES */

declare @procName varchar(500)
declare cur cursor 

for select [name] from sys.objects where type = 'p'
open cur
fetch next from cur into @procName
while @@fetch_status = 0
begin
    exec('drop procedure [' + @procName + ']')
    fetch next from cur into @procName
end
close cur
deallocate cur


DELETE  FROM Student
DELETE  FROM Instructor
DELETE  FROM _User
DELETE	FROM Choices
DELETE	FROM Question
DELETE	FROM Course

