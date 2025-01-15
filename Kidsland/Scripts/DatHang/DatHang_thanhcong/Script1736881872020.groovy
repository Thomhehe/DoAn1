import static com.kms.katalon.core.checkpoint.CheckpointFactory.findCheckpoint
import static com.kms.katalon.core.testcase.TestCaseFactory.findTestCase
import static com.kms.katalon.core.testdata.TestDataFactory.findTestData
import static com.kms.katalon.core.testobject.ObjectRepository.findTestObject
import static com.kms.katalon.core.testobject.ObjectRepository.findWindowsObject
import com.kms.katalon.core.checkpoint.Checkpoint as Checkpoint
import com.kms.katalon.core.cucumber.keyword.CucumberBuiltinKeywords as CucumberKW
import com.kms.katalon.core.mobile.keyword.MobileBuiltInKeywords as Mobile
import com.kms.katalon.core.model.FailureHandling as FailureHandling
import com.kms.katalon.core.testcase.TestCase as TestCase
import com.kms.katalon.core.testdata.TestData as TestData
import com.kms.katalon.core.testng.keyword.TestNGBuiltinKeywords as TestNGKW
import com.kms.katalon.core.testobject.TestObject as TestObject
import com.kms.katalon.core.webservice.keyword.WSBuiltInKeywords as WS
import com.kms.katalon.core.webui.keyword.WebUiBuiltInKeywords as WebUI
import com.kms.katalon.core.windows.keyword.WindowsBuiltinKeywords as Windows
import internal.GlobalVariable as GlobalVariable
import org.openqa.selenium.Keys as Keys

WebUI.openBrowser('')

WebUI.navigateToUrl('https://kidsland.vn/')

WebUI.maximizeWindow()

WebUI.scrollToElement(findTestObject('DatHang/Page_Cha thy Website  chi tr em no nhiu  nh_d805e3/img_B  chi ng Ray tu ha Plarail Set Series _82db16'), 
    0)

WebUI.click(findTestObject('Object Repository/DatHang/Page_Cha thy Website  chi tr em no nhiu  nh_d805e3/img_B  chi ng Ray tu ha Plarail Set Series _82db16'))

WebUI.click(findTestObject('DatHang/Page_B  Chi E3753A ng Ray Cng Trnh a Tng HAPE   chi tr em Kidsland.vn/button_Mua ngay'))

WebUI.setText(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_H v tn_billing_addressfull_name'), 
    'Phạm')

WebUI.setText(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_Email_checkout_useremail'), 
    'phamthom249@gmail.com')

WebUI.setText(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_S in thoi_billing_addressphone'), 
    '0985829610')

WebUI.setText(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_a ch_billing_addressaddress1'), 
    'Lạc Cầu')

WebUI.selectOptionByValue(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/select_Chn tnh  thnh H Ch MinhH Ni NngAn Gi_3f3e70'), 
    '1', true)

WebUI.scrollToElement(findTestObject('DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/span_Tip tc n phng thc thanh ton'), 
    0)

WebUI.click(findTestObject('Object Repository/DatHang/Page_chi tr em Kidsland.vn - Thanh ton n hng/span_Tip tc n phng thc thanh ton'))

WebUI.verifyTextPresent('Phương thức vận chuyển', false)

WebUI.closeBrowser()

