select *
from �ǥ�
where �ʧO='�k'

select *
from �ǥ�
where �m�W='���|�w'

select *
from �ǥ�
where �Ǹ�='S002'

select *
from ���u
where �~��>=50000

select *
from �ǥ�
where �ͤ�>='1991/1/1'


--��X�ǥ͸�Ƥ�����g�ͤ骺�H
select *
from �ǥ�
where �ͤ� is null

--��X���u��Ƥ�����g�q�ܪ��H
select *
from ���u
where �q�� is null
----------------------------------
--like�B��l(�ҽk�d��)
--%  :�N��0~n�ӥ��N�r��
--_  :�N��1�Ӫ����N�r��
--[] :��b�����̪����N�r��

select *
from �ǥ�
where �m�W like '��%'

select *
from �ǥ�
where �m�W like '��_'


seLeCt *
from �б�
where ��t like 'c%s'

seLeCt *
from �б�
where ��t like 'c_s'


seLeCt *
from �б�
where ��t like '%[cklj]%'

seLeCt *
from �б�
where ��t like '%c%' or  ��t like '%k%' or  ��t like '%l%' or ��t like '%j%'


seLeCt *
from �б�
where ��t like '%[^cklj]%'

seLeCt *
from �б�
where ��t like '%[A-DW-Z0-5]%'

seLeCt *
from �б�
where ��t like '%[ABCDWXYZ012345]%'
--------------------------------------
--between...and...�B��

select * 
from ���u 
where �~��>=25000 and �~��<=55000


select * 
from ���u 
where �~�� between 25000 and 55000
--------------------
--in�B��l
select *
from �ҵ{
where �ҵ{�s��='CS101' or �ҵ{�s��='CS213' 
or �ҵ{�s��='CS349' or �ҵ{�s��='CS999'


select *
from �ҵ{
where �ҵ{�s�� in ('CS101','CS213','CS349','CS999')



