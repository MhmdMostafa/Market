USE market;

INSERT INTO main_info(CommercialRegister, TaxNumber, ContactNumber, NameEn, NameAr)
VALUES ('1131293352', '300576277800003', '0504166955', 'Youssef Abdullah Al-Fawaz Veterinary Pharmacy', N'صيدلية يوسف عبدالله الفويز البيطرية');


INSERT INTO continents (NameEn, NameAr)
VALUES ('Asia', N'آسيا');
INSERT INTO continents (NameEn, NameAr)
VALUES ('Africa', N'أفريقيا');
INSERT INTO continents (NameEn, NameAr)
VALUES ('Europ', N'أوروبا');
INSERT INTO continents (NameEn, NameAr)
VALUES ('North America', N'أمريكا الشمالية');
INSERT INTO continents (NameEn, NameAr)
VALUES ('South America', N'أمريكا الجنوبية');
INSERT INTO continents (NameEn, NameAr)
VALUES ('Australia', N'أستراليا');
INSERT INTO continents (NameEn, NameAr)
VALUES ('Antarctica', N'المتجمدة الجنوبية');


INSERT INTO countries (ContinentID, CallingCode, NameEn, NameAr, Shortcut)
VALUES (1, '00966', 'Saudi Arabia', N'المملكة العربية السعودية', 'KSA');

INSERT INTO cities (CountryID, NameEn, NameAr)
VALUES (1, 'Riyadh', N'الرياض');

INSERT INTO contact_type (NameEn, NameAr)
VALUES ('Fax', N'فاكس');
INSERT INTO contact_type (NameEn, NameAr)
VALUES ('Phone', N'جوال');
INSERT INTO contact_type (NameEn, NameAr)
VALUES ('Telephone', N'هاتف');


INSERT INTO hands (NameEn, NameAr)
VALUES ('Right hand', N'اليد اليمنى');
INSERT INTO hands (NameEn, NameAr)
VALUES ('Left hand', N'اليد اليسرى');

INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (1, 'Thumb', N'الإبهام');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (1, 'Index', N'السبابة');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (1, 'Middle', N'الوسطى');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (1, 'Ring', N'البنصر');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (1, 'Pinkie', N'الخنصر');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (2, 'Thumb', N'الإبهام');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (2, 'Index', N'السبابة');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (2, 'Middle', N'الوسطى');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (2, 'Ring', N'البنصر');
INSERT INTO hand_fingers (HandID, NameEn, NameAr)
VALUES (2, 'Pinkie', N'الخنصر');


INSERT INTO gender (NameEn, NameAr, Shortcut)
VALUES ('Male', N'ذكر', 'M');
INSERT INTO gender (NameEn, NameAr, Shortcut)
VALUES ('Female', N'أنثى', 'W');

INSERT INTO currencies (NameEn, NameAr, Shortcut)
VALUES ('Saudi Riyal', N'ريال سعودي', 'SAR');
INSERT INTO currencies (NameEn, NameAr, Shortcut)
VALUES ('United States dollar', N'دولار أمريكي', 'USD');

INSERT INTO invoice_type (NameEn, NameAr)
VALUES ('Purchases', N'مشتريات');
INSERT INTO invoice_type (NameEn, NameAr)
VALUES ('Purchases return', N'مردود مشتريات');
INSERT INTO invoice_type (NameEn, NameAr)
VALUES ('Sales', N'مبيعات');
INSERT INTO invoice_type (NameEn, NameAr)
VALUES ('Sales return', N'مردود مبيعات');


INSERT INTO payment_mechanisms (NameEn, NameAr)
VALUES ('Credit', N'آجل');
INSERT INTO payment_mechanisms (NameEn, NameAr)
VALUES ('Cash', N'نقدي');

INSERT INTO payment_methods (NameEn, NameAr)
VALUES ('Cash', N'كاش');
INSERT INTO payment_methods (NameEn, NameAr)
VALUES ('Visa', N'شبكة');
INSERT INTO payment_methods (NameEn, NameAr)
VALUES ('Bank Transfer', N'تحويل');
INSERT INTO payment_methods (NameEn, NameAr)
VALUES ('Check', N'شيك');

INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Gram', N'غرام', 'G');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Kilo gram', N'كيلو غرام', 'Kg');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('millimeter', N'مليمتر', 'Mm');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Centimeter', N'سنتيمتر', 'Cm');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Meter', N'متر', 'M');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Milliliters', N'مليلتر', 'Ml');
INSERT INTO units_value (NameEn, NameAr, Shortcut)
VALUES ('Liter', N'لتر', 'L');

INSERT INTO products_groub (NameEn, NameAr)
VALUES ('None', N'بدون');

INSERT INTO products_type (NameEn, NameAr)
VALUES ('Medicine', N'دواء');
INSERT INTO products_type (NameEn, NameAr)
VALUES ('Treatment', N'علاج');

INSERT INTO warehouses (NameEn, NameAr)
VALUES ('Ours', N'مستودعنا');

INSERT INTO warehouses (NameEn, NameAr)
VALUES ('Supplier', N'مزوّد');

INSERT INTO nav_sections (WarehousesID, NameEn, NameAr)
VALUES (2,'None', N'بدون');

INSERT INTO nav_rows (SectionID, NameEn, NameAr)
VALUES (1,'None', N'بدون');

INSERT INTO nav_columns (SectionID, NameEn, NameAr)
VALUES (1,'None', N'بدون');

INSERT INTO emp_group (NameEn)
VALUES ('Administrator');
INSERT INTO emp_group (NameEn)
VALUES ('Database Administrator');

INSERT INTO emp_permissions (NameEn)
VALUES ('Add new permissions');
INSERT INTO emp_permissions (NameEn)
VALUES ('Edit permissions');
INSERT INTO emp_permissions (NameEn)
VALUES ('Add employee');

INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (1,1,TRUE);
INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (1,2,TRUE);
INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (1,3,TRUE);
INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (2,1,TRUE);
INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (2,2,TRUE);
INSERT INTO emp_group_permissions (EmpGroupID, PermissionID, PermissionState)
VALUES (2,3,TRUE);

INSERT INTO employees (EmpGroupID, UserName, Pass_word, GenderID)
VALUES (1, 'admin',MD5('admin'),1);

INSERT INTO customer_groups (NameEn, NameAr)
VALUES ('Normal',N'عادي');

INSERT INTO customers (CustomerGroupID, NameEn, NameAr)
VALUES (1,'Unknown', N'غير معروف');

INSERT INTO suppliers (NameEn, NameAr, VatNumber, Description)
VALUES ('Unknown', N'غير معروف', 'Sd123123', 'Used to start the market');






INSERT INTO invoices (InvoiceTypeID, PaymentMethodID, PaymentMechanismeID, EmpID, InvoiceDate, Discount, VAT, Total, Paid,Credit, Remain, CurrencyID, Description)
VALUES (1,'Unknown', N'غير معروف');
