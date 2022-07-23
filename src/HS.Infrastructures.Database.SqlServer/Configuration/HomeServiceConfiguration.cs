﻿using HS.Domain.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace HS.Infrastructures.Database.Repos.Ef.Configuration
{
    public class HomeServiceConfiguration : IEntityTypeConfiguration<HomeService>
    {
        public void Configure(EntityTypeBuilder<HomeService> builder)
        {
            builder.HasKey(x => x.Id);
            builder.ToTable("HomeServices");

            #region SeedData
            builder.HasData(
               new HomeService { Id = 1, HomeServiceSubCategoryId = 1, Name = "کاشی و سرامیک", ImgSrc = "2ce018e0-9826-4003-bcfa-3ddacc7d37b0.webp" ,BasePrice=5000000 },
               new HomeService { Id = 2, HomeServiceSubCategoryId = 1, Name = "بنایی ساختمان", ImgSrc = "e7472819-17a4-4d71-827a-89289c031373.webp", BasePrice = 4000000 },
               new HomeService { Id = 3, HomeServiceSubCategoryId = 1, Name = "گچ کاری", ImgSrc = "34b130ba-5bf6-4ca4-8d34-f8071d707ff8.webp", BasePrice = 6000000 },
               new HomeService { Id = 4, HomeServiceSubCategoryId = 1, Name = "کارگر ساده", ImgSrc = "35de9364-d86b-4fdb-8758-31e89a7305f5.webp", BasePrice = 2500000 },
               new HomeService { Id = 5, HomeServiceSubCategoryId = 1, Name = "بازسازی", ImgSrc = "2cd703db-36aa-4921-9f12-0033d6b44ffe.webp", BasePrice = 30000000 },
               new HomeService { Id = 6, HomeServiceSubCategoryId = 1, Name = "کانال سازی و دریچه کولر", ImgSrc = "b6b376ac-3bcf-48a3-b055-6a7c20dd4dd0.webp", BasePrice = 5000000 },
               new HomeService { Id = 7, HomeServiceSubCategoryId = 1, Name = "عایق کاری و ایزوگام", ImgSrc = "dac1bb2d-374d-4ef9-8de2-bb2f1082714b.webp" , BasePrice = 6800000 },
               new HomeService { Id = 8, HomeServiceSubCategoryId = 1, Name = "سنگ کاری", ImgSrc = "a264b5eb-c52a-42d0-b70b-db5091869be7.webp",BasePrice = 30000000 },
               new HomeService { Id = 9, HomeServiceSubCategoryId = 1, Name = "سیمان کاری", ImgSrc = "a845202d-032c-406a-b8c9-b07217340951.webp", BasePrice = 30000000 },
               new HomeService { Id = 10, HomeServiceSubCategoryId = 2, Name = "نقاشی ساختمان", ImgSrc = "f172da2f-9444-4891-b693-03099e238fbc.webp", BasePrice = 30000000 },
               new HomeService { Id = 11, HomeServiceSubCategoryId = 2, Name = "کابینت", ImgSrc = "1498af45-eef9-4b71-a733-42a6b62b3ee7.webp", BasePrice = 30000000 },
               new HomeService { Id = 12, HomeServiceSubCategoryId = 2, Name = "کاغذ دیواری", ImgSrc = "a836a67f-da40-4a4c-905e-48bf386d4726.webp", BasePrice = 30000000 },
               new HomeService { Id = 13, HomeServiceSubCategoryId = 2, Name = "نجاری", ImgSrc = "ea35c1c1-c87e-403a-811f-a04ed5da8224.webp", BasePrice = 30000000 },
               new HomeService { Id = 14, HomeServiceSubCategoryId = 2, Name = "کفسابی", ImgSrc = "8dfe930c-1ed7-4592-855e-252c3105e237.webp", BasePrice = 30000000 },
               new HomeService { Id = 15, HomeServiceSubCategoryId = 2, Name = "کفپوش", ImgSrc = "d6724f46-cb4c-4f4f-bd3f-2c1fec484043.webp", BasePrice = 30000000 },
               new HomeService { Id = 16, HomeServiceSubCategoryId = 2, Name = "پارکت", ImgSrc = "4407bd89-224a-4967-bef7-39e337936d23.webp", BasePrice = 30000000 },
               new HomeService { Id = 17, HomeServiceSubCategoryId = 2, Name = "لمینت", ImgSrc = "844dedd7-0876-4a81-bc4c-ff6beddafa06.webp", BasePrice = 30000000 },
               new HomeService { Id = 18, HomeServiceSubCategoryId = 2, Name = "موکت", ImgSrc = "7a30dcfa-8d95-4759-84fb-2b211ac4b4ed.webp", BasePrice = 30000000 },
               new HomeService { Id = 19, HomeServiceSubCategoryId = 2, Name = "دوخت پرده", ImgSrc = "ed828d72-5110-40b3-8a53-be2f8ed4bb7f.webp", BasePrice = 30000000 },
               new HomeService { Id = 20, HomeServiceSubCategoryId = 2, Name = "مبلمان", ImgSrc = "4d79e2a7-edac-473c-9753-543225e70346.webp", BasePrice = 30000000 },
               new HomeService { Id = 21, HomeServiceSubCategoryId = 2, Name = "سرویس خواب", ImgSrc = "329f3061-42b5-428f-b793-5f6362631cc4.webp", BasePrice = 30000000 },
               new HomeService { Id = 22, HomeServiceSubCategoryId = 2, Name = "سقف کاذب", ImgSrc = "30fda66e-b645-46bf-8f50-135ab117e695.webp", BasePrice = 30000000 },
               new HomeService { Id = 23, HomeServiceSubCategoryId = 3, Name = "نمای ساختمان", ImgSrc = "8e0d0856-315f-43f3-907a-3c2271f10628.webp", BasePrice = 30000000 },
               new HomeService { Id = 24, HomeServiceSubCategoryId = 3, Name = "تعمیر نمای ساختمان", ImgSrc = "3e8e8c0f-99eb-44d1-ab2a-b1db73e666bb.webp", BasePrice = 30000000 },
               new HomeService { Id = 25, HomeServiceSubCategoryId = 4, Name = "شیشه بری", ImgSrc = "ff709f66-fbb0-47e9-a622-106e4a1b0d03.webp", BasePrice = 30000000 },
               new HomeService { Id = 26, HomeServiceSubCategoryId = 4, Name = "توری پنجره", ImgSrc = "554b399f-6347-40c6-aaae-a11d173766ad.webp", BasePrice = 30000000 },
               new HomeService { Id = 27, HomeServiceSubCategoryId = 4, Name = "نصب درب چوبی", ImgSrc = "6d3e0935-6c7c-4a7b-92c8-bff55e6ddcbe.webp", BasePrice = 30000000 },
               new HomeService { Id = 28, HomeServiceSubCategoryId = 5, Name = "جوشکاری و آهنگری", ImgSrc = "35cb61d4-637a-4cc7-96a2-34e39782bf96.webp", BasePrice = 30000000 },
               new HomeService { Id = 29, HomeServiceSubCategoryId = 5, Name = "کلید سازی", ImgSrc = "d01f38eb-92ed-4a75-93b1-e512ee485d93.webp", BasePrice = 30000000 },
               new HomeService { Id = 30, HomeServiceSubCategoryId = 6, Name = "گل و گیاه آپارتمانی", ImgSrc = "7b9f726c-0d1b-4d80-8bdd-1da5d4ddfeb6.webp", BasePrice = 30000000 },
               new HomeService { Id = 31, HomeServiceSubCategoryId = 6, Name = "باغبانی", ImgSrc = "b86725c4-2d69-4911-af66-74ba8eaf0a2c.webp", BasePrice = 30000000 },
               new HomeService { Id = 32, HomeServiceSubCategoryId = 7, Name = "کولر آبی", ImgSrc = "dbad83e3-bee2-4780-b52d-07850e7875da.webp", BasePrice = 30000000 },
               new HomeService { Id = 33, HomeServiceSubCategoryId = 7, Name = "کولر گازی", ImgSrc = "8b54a660-e292-4be8-8599-3157f26821af.webp", BasePrice = 30000000 },
               new HomeService { Id = 34, HomeServiceSubCategoryId = 7, Name = "پکیج", ImgSrc = "f91f1891-59c9-4f98-a187-0b0f7df31ae6.webp", BasePrice = 30000000 },
               new HomeService { Id = 35, HomeServiceSubCategoryId = 7, Name = "آبگرمکن", ImgSrc = "c09a0de0-0565-4c90-a9f7-250b6ca8b5f1.webp", BasePrice = 30000000 },
               new HomeService { Id = 36, HomeServiceSubCategoryId = 7, Name = "فن‌کویل", ImgSrc = "3a603b3a-ef24-4c08-9034-9900b0c3b210.webp", BasePrice = 30000000 },
               new HomeService { Id = 37, HomeServiceSubCategoryId = 7, Name = "چیلر و هواساز", ImgSrc = "5809f193-9a69-4a50-8bb7-a2a8bede30d6.webp", BasePrice = 30000000 },
               new HomeService { Id = 38, HomeServiceSubCategoryId = 7, Name = "رادیاتور شوفاژ", ImgSrc = "210f7785-befe-4844-9b4a-fd569f581e0c.webp", BasePrice = 30000000 },
               new HomeService { Id = 39, HomeServiceSubCategoryId = 7, Name = "موتورخانه", ImgSrc = "33647fdc-9293-4b5d-8c95-d460631d4d96.webp", BasePrice = 30000000 },
               new HomeService { Id = 40, HomeServiceSubCategoryId = 7, Name = "بخاری گازی", ImgSrc = "2a4a15fb-bcca-4080-aca6-48b56490503c.webp", BasePrice = 30000000 },
               new HomeService { Id = 41, HomeServiceSubCategoryId = 7, Name = "شومینه گازی", ImgSrc = "0dfa16d5-03dc-4792-97b2-a2c53af7d7dc.webp", BasePrice = 30000000 },
               new HomeService { Id = 42, HomeServiceSubCategoryId = 8, Name = "لوله کشی", ImgSrc = "3d246b0d-4045-4bca-a5d9-6fe88ce95d1e.webp", BasePrice = 30000000 },
               new HomeService { Id = 43, HomeServiceSubCategoryId = 8, Name = "شیرآلات ساختمانی", ImgSrc = "dc83b92f-188b-4763-8113-cfea3b7bc885.webp", BasePrice = 30000000 },
               new HomeService { Id = 44, HomeServiceSubCategoryId = 8, Name = "لوله بازکنی", ImgSrc = "7b297bb6-8ed8-4302-a4ad-a72859c53a74.webp", BasePrice = 30000000 },
               new HomeService { Id = 45, HomeServiceSubCategoryId = 8, Name = "توالت فرنگی", ImgSrc = "9fd2a021-c0f0-4c62-af06-52b54b7bd9a6.webp", BasePrice = 30000000 },
               new HomeService { Id = 46, HomeServiceSubCategoryId = 8, Name = "پمپ آب", ImgSrc = "9a0b0bb3-b077-4f75-817c-3e7b35889acb.webp", BasePrice = 30000000 },
               new HomeService { Id = 47, HomeServiceSubCategoryId = 8, Name = "لوله‌ کشی گاز", ImgSrc = "46364dd7-c2a5-4e9e-bc05-8d2c11e2f3cc.webp", BasePrice = 30000000 },
               new HomeService { Id = 48, HomeServiceSubCategoryId = 8, Name = "تخلیه چاه", ImgSrc = "fe75e004-e7cd-4db1-800b-5d5a797a75bf.webp", BasePrice = 30000000 },
               new HomeService { Id = 49, HomeServiceSubCategoryId = 8, Name = "فلاش تانک", ImgSrc = "1a9ce365-a1bf-4e98-8579-18d4fbd22667.webp", BasePrice = 30000000 },
               new HomeService { Id = 50, HomeServiceSubCategoryId = 8, Name = "روشویی و دست‌شور", ImgSrc = "0c653840-4235-468b-a0ee-3a2eb24b1058.webp", BasePrice = 30000000 },
               new HomeService { Id = 51, HomeServiceSubCategoryId = 8, Name = "سینک ظرفشویی", ImgSrc = "a6fed297-3438-43d8-94f2-e25c8e6e0533.webp", BasePrice = 30000000 },
               new HomeService { Id = 52, HomeServiceSubCategoryId = 9, Name = "برق کاری ساختمان", ImgSrc = "1e72d779-6c79-40c9-bd8b-051db9cd5ec5.webp", BasePrice = 30000000 },
               new HomeService { Id = 53, HomeServiceSubCategoryId = 9, Name = "آیفون تصویری", ImgSrc = "8d5cc788-6dbd-45e4-84f0-84308c7a21b0.webp", BasePrice = 30000000 },
               new HomeService { Id = 54, HomeServiceSubCategoryId = 9, Name = "لوستر", ImgSrc = "9ed35b07-753a-43cb-aed8-3bc8dc757638.webp", BasePrice = 30000000 },
               new HomeService { Id = 55, HomeServiceSubCategoryId = 9, Name = "دوربین مداربسته", ImgSrc = "706e32b5-a1af-4363-91c3-fb2cfb612905.webp", BasePrice = 30000000 },
               new HomeService { Id = 56, HomeServiceSubCategoryId = 9, Name = "هواکش", ImgSrc = "a3aea78f-a04f-4198-87e2-a85ad73e91ea.webp", BasePrice = 30000000 },
               new HomeService { Id = 57, HomeServiceSubCategoryId = 9, Name = "آنتن دیجیتال", ImgSrc = "02d218f0-1be8-45e3-9aa1-939768f70591.webp", BasePrice = 30000000 },
               new HomeService { Id = 58, HomeServiceSubCategoryId = 9, Name = "نورپردازی ساختمان", ImgSrc = "b384f9cf-023d-405f-9763-b38da76ddbe8.webp", BasePrice = 30000000 },
               new HomeService { Id = 59, HomeServiceSubCategoryId = 9, Name = "تایمر مشاعات", ImgSrc = "c5e8e489-1cb1-4126-8b41-5aeda52f3aaf.webp", BasePrice = 30000000 },
               new HomeService { Id = 60, HomeServiceSubCategoryId = 9, Name = "جعبه فیوز", ImgSrc = "6432de25-5492-4eb6-850f-b0d77af90d1b.webp", BasePrice = 30000000 },
               new HomeService { Id = 61, HomeServiceSubCategoryId = 9, Name = "داکت کشی و ترانکینگ", ImgSrc = "51d9a954-77c2-4ef8-b0de-8f5d09160e8e.webp", BasePrice = 30000000 },
               new HomeService { Id = 62, HomeServiceSubCategoryId = 10, Name = "سیم کشی تلفن", ImgSrc = "36d05574-0b49-4a99-adb3-6dc22577b8d2.webp", BasePrice = 30000000 },
               new HomeService { Id = 63, HomeServiceSubCategoryId = 10, Name = "سیم کشی سانترال", ImgSrc = "16925f86-c028-4899-aa40-069f31d47b55.webp", BasePrice = 30000000 },
               new HomeService { Id = 64, HomeServiceSubCategoryId = 11, Name = "صافکاری و نقاشی خودرو", ImgSrc = "7583b4a7-2ed5-4699-8bde-f416e78dd226.webp", BasePrice = 30000000 },
               new HomeService { Id = 65, HomeServiceSubCategoryId = 11, Name = "تعویض روغن", ImgSrc = "0258e8d5-9668-4893-8d15-0183145d0fab.webp", BasePrice = 30000000 },
               new HomeService { Id = 66, HomeServiceSubCategoryId = 11, Name = "تعمیر خودرو", ImgSrc = "454eca89-8ba7-4fbf-9270-2aeb3fc4879f.webp", BasePrice = 30000000 },
               new HomeService { Id = 67, HomeServiceSubCategoryId = 11, Name = "برق خودرو", ImgSrc = "7014ff29-f51c-4e56-83b7-32f78341c1e4.webp", BasePrice = 30000000 },
               new HomeService { Id = 68, HomeServiceSubCategoryId = 12, Name = "اسباب کشی", ImgSrc = "15b1016e-eede-448d-8a3e-c832030d4507.webp", BasePrice = 30000000 },
               new HomeService { Id = 69, HomeServiceSubCategoryId = 13, Name = "حمل بار ", ImgSrc = "d7946c6f-43bb-4ad5-8684-043e70fed7f7.webp", BasePrice = 30000000 },
               new HomeService { Id = 70, HomeServiceSubCategoryId = 14, Name = "یخچال", ImgSrc = "3a805751-f8ce-47fd-8e78-0429ee6a4c52.webp", BasePrice = 30000000 },
               new HomeService { Id = 71, HomeServiceSubCategoryId = 14, Name = "ماشین ظرفشویی", ImgSrc = "69c43dcd-d644-4156-8e0f-06002ad6b3e8.webp", BasePrice = 30000000 },
               new HomeService { Id = 72, HomeServiceSubCategoryId = 14, Name = "مایکروفر", ImgSrc = "83bdaeea-f908-405b-9208-eeddbed88c5e.webp", BasePrice = 30000000 },
               new HomeService { Id = 73, HomeServiceSubCategoryId = 14, Name = "اجاق برقی", ImgSrc = "4e58b3cb-36de-43a4-83e0-72632d1e1e86.webp", BasePrice = 30000000 },
               new HomeService { Id = 74, HomeServiceSubCategoryId = 14, Name = "هود آشپزخانه", ImgSrc = "4df97a51-4335-4863-86de-1cc0bee8356d.webp", BasePrice = 30000000 },
               new HomeService { Id = 75, HomeServiceSubCategoryId = 14, Name = "اجاق گاز", ImgSrc = "0b84d3f6-89d4-4873-9157-b2d9fc2f51c5.webp", BasePrice = 30000000 },
               new HomeService { Id = 76, HomeServiceSubCategoryId = 15, Name = "ماشین لباسشویی", ImgSrc = "aded05f5-8c4b-451b-b58f-d692c6e08d84.webp", BasePrice = 30000000 },
               new HomeService { Id = 77, HomeServiceSubCategoryId = 15, Name = "اتو بخار", ImgSrc = "7f227268-ba59-457b-afcb-dd76a256d07d.webp", BasePrice = 30000000 },
               new HomeService { Id = 78, HomeServiceSubCategoryId = 15, Name = "اتو پرس", ImgSrc = "35bc08ad-7f9c-4a10-8ea6-c5f9edf9ea0e.webp", BasePrice = 30000000 },
               new HomeService { Id = 79, HomeServiceSubCategoryId = 15, Name = "جاروبرقی", ImgSrc = "d04efd6a-2c16-4e57-afb1-cdaaccf91427.webp", BasePrice = 30000000 },
               new HomeService { Id = 80, HomeServiceSubCategoryId = 15, Name = "جارو شارژی", ImgSrc = "a01bef88-058c-4caf-ad4a-7fedcedf9ba6.webp", BasePrice = 30000000 },
               new HomeService { Id = 81, HomeServiceSubCategoryId = 16, Name = "تلویزیون", ImgSrc = "4c7b8c4e-c292-486c-bf1a-0d15e551c0e8.webp", BasePrice = 30000000 },
               new HomeService { Id = 82, HomeServiceSubCategoryId = 16, Name = "سینما خانگی", ImgSrc = "cb580eff-96fb-4ecd-bc3a-39e43c9e7062.webp", BasePrice = 30000000 },
               new HomeService { Id = 83, HomeServiceSubCategoryId = 17, Name = "دستگاه کپی", ImgSrc = "587fb9ab-11ca-4e29-a6f2-0404ca1c1ef2.webp", BasePrice = 30000000 },
               new HomeService { Id = 84, HomeServiceSubCategoryId = 17, Name = "فکس", ImgSrc = "88e26199-0184-4b06-865b-dfab22950800.webp", BasePrice = 30000000 },
               new HomeService { Id = 85, HomeServiceSubCategoryId = 17, Name = "پرینتر", ImgSrc = "7296d9ec-b48d-4225-bb36-23ceb5d75888.webp", BasePrice = 30000000 },
               new HomeService { Id = 86, HomeServiceSubCategoryId = 18, Name = "پارتیشن اداری", ImgSrc = "15dd3bcd-8c99-496c-b53d-a4c6be1f7cf1.webp", BasePrice = 30000000 },
               new HomeService { Id = 87, HomeServiceSubCategoryId = 19, Name = "نظافت دوره ای", ImgSrc = "d35afbab-349a-40a5-9920-c7aaf0088bf8.webp", BasePrice = 30000000 },
               new HomeService { Id = 88, HomeServiceSubCategoryId = 19, Name = "نظافت منزل", ImgSrc = "53b6758b-6df7-4149-a1fb-179f8c14fe69.webp", BasePrice = 30000000 },
               new HomeService { Id = 89, HomeServiceSubCategoryId = 19, Name = "نظافت ساختمان", ImgSrc = "428cfcf0-6cbb-4fc5-a425-24950f13c60d.webp", BasePrice = 30000000 },
               new HomeService { Id = 90, HomeServiceSubCategoryId = 19, Name = "نظافت شرکت و اداره", ImgSrc = "12b6bd85-b5fb-4a6e-b3ef-6f4a7393601d.webp", BasePrice = 30000000 },
               new HomeService { Id = 91, HomeServiceSubCategoryId = 19, Name = "ضدعفونی منزل و محل کار", ImgSrc = "eb16cbf2-f8ef-4bcc-99fc-1ce8a42b7f5f.webp", BasePrice = 30000000 },
               new HomeService { Id = 92, HomeServiceSubCategoryId = 20, Name = "خشکشویی آنلاین", ImgSrc = "6e672608-99a6-4f78-88b1-380fc3a884ba.webp", BasePrice = 30000000 },
               new HomeService { Id = 93, HomeServiceSubCategoryId = 20, Name = "خشکشویی پرده", ImgSrc = "a08223f4-a911-41d9-9efc-6173f7771021.webp", BasePrice = 30000000 },
               new HomeService { Id = 94, HomeServiceSubCategoryId = 21, Name = "قالیشویی آنلاین", ImgSrc = "65dc2285-4c94-4a31-aa6e-bb8000fc9402.webp", BasePrice = 30000000 },
               new HomeService { Id = 95, HomeServiceSubCategoryId = 21, Name = "مبل شویی", ImgSrc = "3e8bf209-ea00-40a5-992c-b5e360bab4fb.webp", BasePrice = 30000000 },
               new HomeService { Id = 96, HomeServiceSubCategoryId = 22, Name = "سمپاشی منازل", ImgSrc = "2fd6426a-ee1a-4bf3-befb-0fa5f3c17885.webp", BasePrice = 30000000 },
               new HomeService { Id = 97, HomeServiceSubCategoryId = 23, Name = "تعمیر موبایل", ImgSrc = "958a54ca-c84f-47f2-8b66-7b84de6d9d2d.webp", BasePrice = 30000000 },
               new HomeService { Id = 98, HomeServiceSubCategoryId = 24, Name = "تعمیر لپ‌تاپ", ImgSrc = "8ddec483-9b8d-4fc9-8a39-987a4ab03873.webp", BasePrice = 30000000 },
               new HomeService { Id = 99, HomeServiceSubCategoryId = 24, Name = "تعمیر سخت افزار کامپیوتر", ImgSrc = "c068e5dd-bcaf-4b83-b9dd-9bfbb060c4e7.webp", BasePrice = 30000000 },
               new HomeService { Id = 100, HomeServiceSubCategoryId = 24, Name = "نصب نرم افزار", ImgSrc = "f7fb5686-f130-4f13-86a0-b6f79d0ce790.webp", BasePrice = 30000000 },
               new HomeService { Id = 101, HomeServiceSubCategoryId = 24, Name = "نصب ویندوز در محل", ImgSrc = "f2d25592-d8c4-4430-badc-839a2fa9eff0.webp", BasePrice = 30000000 },
               new HomeService { Id = 102, HomeServiceSubCategoryId = 25, Name = "تعمیر مودم اینترنت", ImgSrc = "7eeea6b2-0a32-4aa5-8244-7f84bcfe200e.webp", BasePrice = 30000000 },
               new HomeService { Id = 103, HomeServiceSubCategoryId = 25, Name = "راه‌ اندازی شبکه کامپیوتری", ImgSrc = "6d22ccda-5eda-48dd-bb26-4095c48447af.webp", BasePrice = 30000000 },
               new HomeService { Id = 104, HomeServiceSubCategoryId = 26, Name = "آزمایش در محل", ImgSrc = "c214ac59-9605-48b4-95bf-1b12a79d870c.webp", BasePrice = 30000000 },
               new HomeService { Id = 105, HomeServiceSubCategoryId = 26, Name = "پرستاری در منزل", ImgSrc = "9d49d3fc-88fe-4fd8-bd12-eba51013a8d6.webp", BasePrice = 30000000 },
               new HomeService { Id = 106, HomeServiceSubCategoryId = 26, Name = "ویزیت پزشک در منزل", ImgSrc = "3f4df8f1-7e51-4d57-b98a-568f1eef5396.webp", BasePrice = 30000000 },
               new HomeService { Id = 107, HomeServiceSubCategoryId = 26, Name = "نوار قلب در محل", ImgSrc = "f73d4d27-3e0b-422e-bad2-deebd9d0467d.webp", BasePrice = 30000000 },
               new HomeService { Id = 108, HomeServiceSubCategoryId = 26, Name = "فیزیوتراپی در منزل", ImgSrc = "64bd6636-1560-4dd6-9499-c72dde33b07e.webp", BasePrice = 30000000 }
               );
            #endregion SeedData

        }
    }
}
