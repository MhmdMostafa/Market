USE market;

INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Asia', 'آسيا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Africa', 'أفريقيا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Europ', 'أوروبا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('North America', 'أمريكا الشمالية');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('South America', 'أمريكا الجنوبية');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Australia', 'أستراليا');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('Antarctica', 'المتجمدة الجنوبية');


INSERT INTO countries (ContinentID, CountryCallingCodeID, CountryNameEN, CountryNameAR)
VALUES (1, '00966', 'Saudi Arabia', 'المملكة العربية السعودية');


INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Fax', 'فاكس');
INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Phone', 'جوال');
INSERT INTO contact_type (ContactNameEN, ContactNameAR)
VALUES ('Telephone', 'هاتف');


INSERT INTO hands (HandNameEN, HandNameAR)
VALUES ('Right hand', 'اليد اليمنى');
INSERT INTO hands (HandNameEN, HandNameAR)
VALUES ('Left hand', 'اليد اليسرى');

INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Thumb', 'الإبهام');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Index', 'السبابة');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Middle', 'الوسطى');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Ring', 'البنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (1, 'Pinkie', 'الخنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Thumb', 'الإبهام');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Index', 'السبابة');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Middle', 'الوسطى');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Ring', 'البنصر');
INSERT INTO hand_fingers (HandID, FingerNameEN, FingerNameAR)
VALUES (2, 'Pinkie', 'الخنصر');

INSERT INTO currencies (CountryID, CurrencyNameEN, CurrencyNameAR, CurrencyShortCut)
VALUES (1, 'Saudi Riyal', 'ريال سعودي', 'SAR');


INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Purchases', 'مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Purchases return', 'مردود مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Sales', 'مبيعات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Sales return', 'مردود مبيعات');


INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'آجل');
INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'نقدي');

INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Cash', 'كاش');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Visa', 'شبكة');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Bamk Transfer', 'تحويل');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Check', 'شيك');


INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Gram', 'غرام', 'g');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Kilo gram', 'كيلو غرام', 'kg');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('millimeter', 'مليمتر', 'mm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Centimeter', 'سنتيمتر', 'cm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Meter', 'متر', 'm');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Milliliters', 'مليلتر', 'ml');
INSERT INTO units_value (UnitValueNameEN, UnitValueNameAR, UnitsValueShortCut)
VALUES ('Liter', 'لتر', 'l');

INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR)
VALUES ('Medicine', 'دواء');
INSERT INTO products_type (ProductTypeNameEN, ProductTypeNameAR)
VALUES ('Treatment', 'علاج');

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

INSERT INTO suppliers (supplierNameEN, supplierNameAR, Discrption)
VALUES ('Unknown', 'غير معروف','Used to start the market');

INSERT INTO customer_groups (CustomerGroupNameEN, CustomerGroupNameAR)
VALUES ('Normal','عادي');

INSERT INTO customers (CustomerGroupID, CustomerNameEN, CustomerNameAR)
VALUES (1,'Unknown', 'غير معروف');

INSERT INTO invoices (InvoiceTypeID, PaymentMethodID, PaymentMechanismeID, EmpID, InvoiceDate, Discount, VAT, Total, Paid,Credit, Remain, CurrencyID, Discrption)
VALUES (1,'Unknown', 'غير معروف');
