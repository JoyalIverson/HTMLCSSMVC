create table HTMLCSSMVC

(
StudentId int not null primary key identity (1,1),
Fullname nvarchar (500) not null,
email nvarchar (500) not null,
phonenumber bigint not null,
message nvarchar (500) not null,
)

select * from HTMLCSSMVC 


drop table HTMLCSSMVC 

--insert sp

create or alter procedure ProductDetailsInsert (@Fullname nvarchar (500),@email nvarchar (500),@phonenumber bigint,@message nvarchar (500))
as
begin

insert into HTMLCSSMVC (Fullname,email,phonenumber,message) values (@Fullname,@email,@phonenumber,@message)

end

exec ProductDetailsInsert 'sabari','sabari@gmail.com',9360164284,'bad'

--select sp
create or alter procedure ProductDetailsSelect (@studentid int) 
as
begin

select * from HTMLCSSMVC where studentid=@studentid
end

-- update sp
create or alter procedure updateProductDetails  (@StudentId int ,@Fullname nvarchar (500),@email nvarchar (500),@phonenumber bigint,@message nvarchar (500))
as
begin

update HTMLCSSMVC set Fullname = @Fullname where StudentId=@StudentId 
end
exec updateProductDetails  4,'joo','sabari@gmail.com',9360164284,'bad'

-- delete sp
create or alter procedure deleteCollegeDetails (@StudentId int)
as
begin
delete from HTMLCSSMVC  where StudentId=@StudentId
end
exec deleteCollegeDetails 1