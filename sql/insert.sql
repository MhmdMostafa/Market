USE market;

INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Asia', N'آسيا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Africa', N'أفريقيا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Europ', N'أوروبا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('North America', N'أمريكا الشمالية');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('South America', N'أمريكا الجنوبية');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Australia', N'أستراليا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Antarctica', N'المتجمدة الجنوبية');


INSERT INTO countries (ContinentID, CountryCallingCodeID, CountryNameEN, CountryNameAR, Shortcut)
VALUES (1, '00966', 'Saudi Arabia', N'المملكة العربية السعودية', 'KSA');


INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Fax', N'فاكس');
INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Phone', N'جوال');
INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Telephone', N'هاتف');


INSERT INTO hands (HandNameEN, HandNameAR)
VALUES ('Right hand', N'اليد اليمنى');
INSERT INTO hands (HandNameEN, HandNameAR)
VALUES ('Left hand', N'اليد اليسرى');

INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Thumb', N'الإبهام');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Index', N'السبابة');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Middle', N'الوسطى');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Ring', N'البنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Pinkie', N'الخنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Thumb', N'الإبهام');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Index', N'السبابة');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Middle', N'الوسطى');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Ring', N'البنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Pinkie', N'الخنصر');

INSERT INTO currencies (CurrencyNameEN, CurrencyNameAR, CurrencyShortCut)
VALUES ('Saudi Riyal', N'ريال سعودي', 'SAR');


INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Purchases', N'مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Purchases return', N'مردود مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Sales', N'مبيعات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Sales return', N'مردود مبيعات');


INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Cridit', N'آجل');
INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Cash', N'نقدي');

INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Cash', N'كاش');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Visa', N'شبكة');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Bamk Transfer', N'تحويل');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Check', N'شيك');


INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Gram', N'غرام', 'g');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Kilo gram', N'كيلو غرام', 'kg');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('millimeter', N'مليمتر', 'mm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Centimeter', N'سنتيمتر', 'cm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Meter', N'متر', 'm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Milliliters', N'مليلتر', 'ml');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Liter', N'لتر', 'l');

INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR)
VALUES ('Medicine', N'دواء');
INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR)
VALUES ('Treatment', N'علاج');

INSERT INTO emp_group (EmpGroupNameEN)
VALUES ('Administrator');
INSERT INTO emp_group (EmpGroupNameEN)
VALUES ('Database Administrator');

INSERT INTO emp_permissions (PermissionNameEN)
VALUES ('Add new permissions');
INSERT INTO emp_permissions (PermissionNameEN)
VALUES ('Edit permissions');
INSERT INTO emp_permissions (PermissionNameEN)
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

INSERT INTO emp_employees (EmpGroupID, UserName, Pass_word)
VALUES (1, 'admin',MD5('admin'));

INSERT INTO suppliers (SupplierNameEN, SupplierNameAR, SupplierVatNumber, Discrption)
VALUES ('Unknown', N'غير معروف', 'sd123123', 'Used to start the market');

INSERT INTO customer_groups (CustomerGroupNameEN, CustomerGroupNameAR)
VALUES ('Normal',N'عادي');

INSERT INTO customers (CustomerGroupID, CustomerNameEN, CustomerNameAR)
VALUES (1,'Unknown', N'غير معروف');

INSERT INTO invoices (InvoiceTypeID, PaymentMethodID, PaymentMechanismeID, EmpID, InvoiceDate, Discount, VAT, Total, Paid,Credit, Remain, CurrencyID, Discrption)
VALUES (1,'Unknown', N'غير معروف');
