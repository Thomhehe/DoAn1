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

WebUI.click(findTestObject('Object Repository/DangKy/Page_thanhcong/i_Hotline_lni lni-user'))

WebUI.click(findTestObject('Object Repository/DangKy/Page_thanhcong/div_ng nhpng k'))

WebUI.setText(findTestObject('Object Repository/DangKy/Page_thanhcong/input_H_customerlast_name'), 'Phạm')

WebUI.setText(findTestObject('Object Repository/DangKy/Page_thanhcong/input_Tn_customerfirst_name'), 'Thơm')

WebUI.setText(findTestObject('Object Repository/DangKy/Page_thanhcong/input_Email_customeremail'), 'emphuongchungtinh@gmail.com')

WebUI.setText(findTestObject('Object Repository/DangKy/Page_thanhcong/input_Mt khu_customerpassword'), 'DihhQLh4ltw=')

WebUI.click(findTestObject('DangKy/Page_thanhcong/button_ng k'))

WebUI.verifyTextPresent('Hi, Phạm Thơm', false)

WebUI.closeBrowser()

