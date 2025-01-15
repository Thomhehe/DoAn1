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

WebUI.scrollToElement(findTestObject('Page_Cha thy Website  chi tr em no nhiu  nh_d805e3/img_B 4 xe m hnh Tomica Gift Highway Set Fo_3dda8b'), 
    0)

WebUI.click(findTestObject('Object Repository/Page_Cha thy Website  chi tr em no nhiu  nh_d805e3/img_B 4 xe m hnh Tomica Gift Highway Set Fo_3dda8b'))

WebUI.click(findTestObject('Object Repository/Page_B  chi Tomica Town Gas Station ENEOS  _d86e62/button_Mua ngay'))

WebUI.setText(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_H v tn_billing_addressfull_name'), 
    hoten)

WebUI.setText(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_Email_checkout_useremail'), 
    email)

WebUI.setText(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_S in thoi_billing_addressphone'), 
    sdt)

WebUI.setText(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/input_a ch_billing_addressaddress1'), 
    dc)

WebUI.selectOptionByValue(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/select_Chn tnh  thnh H Ch MinhH Ni NngAn Gi_3f3e70'), 
    tinhthanh, true)

WebUI.selectOptionByValue(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/select_Chn qun  huynHuyn n ThiHuyn Chu Gian_8c7a94'), 
    quanhuyen, true)

WebUI.selectOptionByValue(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/select_Chn phng  xTh trn Yn MX Giai PhmX Ho_280059'), 
    phuongxa, true)

WebUI.click(findTestObject('Object Repository/Page_chi tr em Kidsland.vn - Thanh ton n hng/i_Tip tc n phng thc thanh ton_btn-spinner i_5992ed'))

WebUI.verifyTextPresent(result, false)

WebUI.closeBrowser()

