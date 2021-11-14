USE market

INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('آسيا', 'Asia');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('أفريقيا', 'Africa');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('أوروبا', 'Europ');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('أمريكا الشمالية', 'North America');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('أمريكا الجنوبية', 'South America');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('أستراليا', 'Australia');
INSERT INTO continents (ContinentNameEN, ContinentNameAR)
VALUES ('المتجمدة الجنوبية', 'Antarctica');


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

INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (1, 'Thumb', 'الإبهام');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (1, 'Index', 'السبابة');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (1, 'Middle', 'الوسطى');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (1, 'Ring', 'البنصر');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (1, 'Pinkie', 'الخنصر');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (2, 'Thumb', 'الإبهام');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (2, 'Index', 'السبابة');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (2, 'Middle', 'الوسطى');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (2, 'Ring', 'البنصر');
INSERT INTO hands (HandIDو FingerNameEN, FingerNameAR)
VALUES (2, 'Pinkie', 'الخنصر');

INSERT INTO currencies (CountryID, CurrencyNameEN, CurrencyNameAR, CurrencyShortCut)
VALUES (1, 'Saudi Riyal', 'ريال سعودي', 'SAR');


INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Left hand', 'مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Left hand', 'مردود مشتريات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Left hand', 'مبيعات');
INSERT INTO invoice_type (InvoiceTypeNameEN, InvoiceTypeNameAR)
VALUES ('Left hand', 'مردود مبيعات');


INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Left hand', 'آجل');
INSERT INTO payment_methods (PaymentMethodNameEN, PaymentMethodNameAR)
VALUES ('Left hand', 'نقدي');

INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'كاش');
INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'شبكة');
INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'تحويل');
INSERT INTO payment_mechanisms (PaymentMechanismeNameEN, PaymentMechanismeNameAR)
VALUES ('Left hand', 'شيك');