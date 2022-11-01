use Shop
go

select p.Name as Product, c.Name as Category
from Products as p left join ProductsCategories as pc on p.Id = pc.ProductId 
left join Categories as c on pc.CategotyId = c.Id

